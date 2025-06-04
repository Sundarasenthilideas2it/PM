// using Microsoft.AspNetCore.Mvc;
// using System.Data;
// using System.Data.SqlClient;
// using ClairTourTiny.Core.Interfaces;
// using ClairTourTiny.Core.Models;
// using System.ComponentModel.DataAnnotations;

// namespace ClairTourTiny.API.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     [Produces("application/json")]
//     public class SubhireEquipmentController : ControllerBase
//     {
//         private readonly IConfiguration _configuration;
//         private readonly ILogger<SubhireEquipmentController> _logger;

//         public SubhireEquipmentController(
//             IConfiguration configuration,
//             ILogger<SubhireEquipmentController> logger)
//         {
//             _configuration = configuration;
//             _logger = logger;
//         }

//         /// <summary>
//         /// Creates purchase orders for selected subhire equipment items
//         /// </summary>
//         /// <param name="request">List of subhire equipment items to create POs for</param>
//         /// <returns>List of created purchase orders with their details</returns>
//         /// <response code="200">Returns the list of created purchase orders</response>
//         /// <response code="400">If the request is invalid</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpPost("create-purchase-orders")]
//         [ProducesResponseType(typeof(ApiResponse<List<PurchaseOrderResult>>), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> CreatePurchaseOrdersForSubhireItems([FromBody] CreateSubhirePORequest request)
//         {
//             try
//             {
//                 if (!ModelState.IsValid)
//                 {
//                     return BadRequest(new ApiResponse<string>
//                     {
//                         Success = false,
//                         Message = "Invalid request data",
//                         Data = string.Join(", ", ModelState.Values
//                             .SelectMany(v => v.Errors)
//                             .Select(e => e.ErrorMessage))
//                     });
//                 }

//                 if (request?.Items == null || !request.Items.Any())
//                 {
//                     return BadRequest(new ApiResponse<string>
//                     {
//                         Success = false,
//                         Message = "No subhire items provided",
//                         Data = null
//                     });
//                 }

//                 var results = new List<PurchaseOrderResult>();
//                 var connectionString = _configuration.GetConnectionString("FinesseConnection");

//                 using var connection = new SqlConnection(connectionString);
//                 await connection.OpenAsync();

//                 // Group items by vendor and site
//                 var groupedItems = request.Items
//                     .GroupBy(x => new { x.EntityNo, x.VendorNo, x.SiteNo })
//                     .Select(g => new
//                     {
//                         g.Key.EntityNo,
//                         g.Key.VendorNo,
//                         g.Key.SiteNo,
//                         Items = g.ToList()
//                     });

//                 foreach (var group in groupedItems)
//                 {
//                     using var transaction = connection.BeginTransaction();
//                     try
//                     {
//                         using var command = new SqlCommand("Create_Purchase_Order_Subhire_Equipment_On_Project", connection, transaction)
//                         {
//                             CommandType = CommandType.StoredProcedure
//                         };

//                         command.Parameters.AddWithValue("@entityno", group.EntityNo);
//                         command.Parameters.AddWithValue("@vendno", group.VendorNo);
//                         command.Parameters.AddWithValue("@siteno", group.SiteNo);
                        
//                         var newPONumberParam = command.Parameters.Add("@newPONumber", SqlDbType.Int);
//                         newPONumberParam.Direction = ParameterDirection.Output;

//                         await command.ExecuteNonQueryAsync();
//                         var newPONumber = (int)newPONumberParam.Value;

//                         // Update equipment subhire records
//                         await UpdateEquipmentSubhireRecords(connection, transaction, group.Items, newPONumber);

//                         await transaction.CommitAsync();

//                         results.Add(new PurchaseOrderResult
//                         {
//                             PurchaseOrderNumber = newPONumber,
//                             EntityNo = group.EntityNo,
//                             VendorNo = group.VendorNo,
//                             SiteNo = group.SiteNo,
//                             Status = "Created",
//                             Items = group.Items
//                         });
//                     }
//                     catch (SqlException ex) when (ex.Number == 2627)
//                     {
//                         await transaction.RollbackAsync();
//                         _logger.LogWarning(ex, "Duplicate PO attempt for EntityNo: {EntityNo}, VendorNo: {VendorNo}, SiteNo: {SiteNo}",
//                             group.EntityNo, group.VendorNo, group.SiteNo);
//                         return BadRequest(new ApiResponse<string>
//                         {
//                             Success = false,
//                             Message = "A purchase order already exists for this vendor and site combination",
//                             Data = null
//                         });
//                     }
//                     catch (Exception ex)
//                     {
//                         await transaction.RollbackAsync();
//                         _logger.LogError(ex, "Error creating PO for EntityNo: {EntityNo}, VendorNo: {VendorNo}, SiteNo: {SiteNo}",
//                             group.EntityNo, group.VendorNo, group.SiteNo);
//                         throw;
//                     }
//                 }

//                 return Ok(new ApiResponse<List<PurchaseOrderResult>>
//                 {
//                     Success = true,
//                     Message = "Purchase orders created successfully",
//                     Data = results
//                 });
//             }
//             catch (Exception ex)
//             {
//                 _logger.LogError(ex, "Error creating purchase orders");
//                 return StatusCode(500, new ApiResponse<string>
//                 {
//                     Success = false,
//                     Message = "An error occurred while creating purchase orders",
//                     Data = ex.Message
//                 });
//             }
//         }

//         /// <summary>
//         /// Gets subhire equipment items for a project
//         /// </summary>
//         /// <param name="entityNo">The project entity number</param>
//         /// <returns>List of subhire equipment items</returns>
//         /// <response code="200">Returns the list of subhire equipment items</response>
//         /// <response code="400">If the entity number is invalid</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpGet("project/{entityNo}")]
//         [ProducesResponseType(typeof(ApiResponse<List<SubhireEquipmentItem>>), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> GetSubhireEquipmentItems([Required] string entityNo)
//         {
//             try
//             {
//                 var connectionString = _configuration.GetConnectionString("FinesseConnection");
//                 using var connection = new SqlConnection(connectionString);
//                 await connection.OpenAsync();

//                 using var command = new SqlCommand("Get_Subhire_Equipment_Items", connection)
//                 {
//                     CommandType = CommandType.StoredProcedure
//                 };
//                 command.Parameters.AddWithValue("@entityno", entityNo);

//                 var items = new List<SubhireEquipmentItem>();
//                 using var reader = await command.ExecuteReaderAsync();
//                 while (await reader.ReadAsync())
//                 {
//                     items.Add(new SubhireEquipmentItem
//                     {
//                         EntityNo = reader["entityno"].ToString(),
//                         VendorNo = reader["vendno"].ToString(),
//                         SiteNo = reader["siteno"].ToString(),
//                         EquipmentCode = reader["equipmentcode"].ToString(),
//                         Description = reader["description"].ToString(),
//                         Quantity = Convert.ToInt32(reader["quantity"]),
//                         StatusCode = reader["statuscode"].ToString(),
//                         PONumber = reader["ponumber"] != DBNull.Value ? Convert.ToInt32(reader["ponumber"]) : null
//                     });
//                 }

//                 return Ok(new ApiResponse<List<SubhireEquipmentItem>>
//                 {
//                     Success = true,
//                     Message = "Subhire equipment items retrieved successfully",
//                     Data = items
//                 });
//             }
//             catch (Exception ex)
//             {
//                 _logger.LogError(ex, "Error retrieving subhire equipment items for entity {EntityNo}", entityNo);
//                 return StatusCode(500, new ApiResponse<string>
//                 {
//                     Success = false,
//                     Message = "An error occurred while retrieving subhire equipment items",
//                     Data = ex.Message
//                 });
//             }
//         }

//         /// <summary>
//         /// Creates equipment subhire transfers for selected items
//         /// </summary>
//         /// <param name="request">List of subhire equipment items to create transfers for</param>
//         /// <returns>List of created transfers with their details</returns>
//         /// <response code="200">Returns the list of created transfers</response>
//         /// <response code="400">If the request is invalid</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpPost("create-transfers")]
//         [ProducesResponseType(typeof(ApiResponse<List<SubhireTransferResult>>), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> CreateEquipmentSubhireTransfers([FromBody] CreateSubhireTransferRequest request)
//         {
//             try
//             {
//                 if (request?.Items == null || !request.Items.Any())
//                 {
//                     return BadRequest(new ApiResponse<string>
//                     {
//                         Success = false,
//                         Message = "No subhire items provided",
//                         Data = null
//                     });
//                 }

//                 var results = new List<SubhireTransferResult>();
//                 var connectionString = _configuration.GetConnectionString("FinesseConnection");

//                 using var connection = new SqlConnection(connectionString);
//                 await connection.OpenAsync();

//                 foreach (var item in request.Items)
//                 {
//                     using var command = new SqlCommand("Create_Equipment_Subhire_Transfer", connection)
//                     {
//                         CommandType = CommandType.StoredProcedure
//                     };

//                     command.Parameters.AddWithValue("@entityno", item.EntityNo);
//                     command.Parameters.AddWithValue("@vendno", item.VendorNo);
//                     command.Parameters.AddWithValue("@siteno", item.SiteNo);
//                     command.Parameters.AddWithValue("@equipmentcode", item.EquipmentCode);
//                     command.Parameters.AddWithValue("@quantity", item.Quantity);
//                     command.Parameters.AddWithValue("@ponumber", item.PONumber);

//                     var transferIdParam = command.Parameters.Add("@transferid", SqlDbType.Int);
//                     transferIdParam.Direction = ParameterDirection.Output;

//                     await command.ExecuteNonQueryAsync();
//                     var transferId = (int)transferIdParam.Value;

//                     results.Add(new SubhireTransferResult
//                     {
//                         TransferId = transferId,
//                         EntityNo = item.EntityNo,
//                         VendorNo = item.VendorNo,
//                         SiteNo = item.SiteNo,
//                         EquipmentCode = item.EquipmentCode,
//                         Quantity = item.Quantity,
//                         PONumber = item.PONumber,
//                         Status = "Created"
//                     });
//                 }

//                 return Ok(new ApiResponse<List<SubhireTransferResult>>
//                 {
//                     Success = true,
//                     Message = "Equipment subhire transfers created successfully",
//                     Data = results
//                 });
//             }
//             catch (Exception ex)
//             {
//                 _logger.LogError(ex, "Error creating equipment subhire transfers");
//                 return StatusCode(500, new ApiResponse<string>
//                 {
//                     Success = false,
//                     Message = "An error occurred while creating equipment subhire transfers",
//                     Data = ex.Message
//                 });
//             }
//         }

//         /// <summary>
//         /// Updates the status of subhire equipment items
//         /// </summary>
//         /// <param name="request">List of subhire equipment items to update</param>
//         /// <returns>List of updated items with their new status</returns>
//         /// <response code="200">Returns the list of updated items</response>
//         /// <response code="400">If the request is invalid</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpPut("update-status")]
//         [ProducesResponseType(typeof(ApiResponse<List<SubhireEquipmentItem>>), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> UpdateSubhireEquipmentStatus([FromBody] UpdateSubhireStatusRequest request)
//         {
//             try
//             {
//                 if (request?.Items == null || !request.Items.Any())
//                 {
//                     return BadRequest(new ApiResponse<string>
//                     {
//                         Success = false,
//                         Message = "No subhire items provided",
//                         Data = null
//                     });
//                 }

//                 var connectionString = _configuration.GetConnectionString("FinesseConnection");
//                 using var connection = new SqlConnection(connectionString);
//                 await connection.OpenAsync();

//                 using var command = new SqlCommand("Update_Subhire_Equipment_Status", connection)
//                 {
//                     CommandType = CommandType.StoredProcedure
//                 };

//                 var entityNoParam = command.Parameters.Add("@entityno", SqlDbType.VarChar, 20);
//                 var vendorNoParam = command.Parameters.Add("@vendno", SqlDbType.VarChar, 20);
//                 var siteNoParam = command.Parameters.Add("@siteno", SqlDbType.VarChar, 20);
//                 var statusCodeParam = command.Parameters.Add("@statuscode", SqlDbType.VarChar, 20);

//                 foreach (var item in request.Items)
//                 {
//                     entityNoParam.Value = item.EntityNo;
//                     vendorNoParam.Value = item.VendorNo;
//                     siteNoParam.Value = item.SiteNo;
//                     statusCodeParam.Value = item.StatusCode;

//                     await command.ExecuteNonQueryAsync();
//                 }

//                 // Get updated items
//                 var updatedItems = await GetSubhireEquipmentItems(request.Items[0].EntityNo);
//                 return Ok(updatedItems);
//             }
//             catch (Exception ex)
//             {
//                 _logger.LogError(ex, "Error updating subhire equipment status");
//                 return StatusCode(500, new ApiResponse<string>
//                 {
//                     Success = false,
//                     Message = "An error occurred while updating subhire equipment status",
//                     Data = ex.Message
//                 });
//             }
//         }

//         /// <summary>
//         /// Gets the subhire equipment summary for a project
//         /// </summary>
//         /// <param name="entityNo">The project entity number</param>
//         /// <returns>Summary of subhire equipment items grouped by vendor</returns>
//         /// <response code="200">Returns the subhire equipment summary</response>
//         /// <response code="400">If the entity number is invalid</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpGet("summary/{entityNo}")]
//         [ProducesResponseType(typeof(ApiResponse<List<SubhireEquipmentSummary>>), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> GetSubhireEquipmentSummary(string entityNo)
//         {
//             try
//             {
//                 if (string.IsNullOrWhiteSpace(entityNo))
//                 {
//                     return BadRequest(new ApiResponse<string>
//                     {
//                         Success = false,
//                         Message = "Entity number is required",
//                         Data = null
//                     });
//                 }

//                 var connectionString = _configuration.GetConnectionString("FinesseConnection");
//                 using var connection = new SqlConnection(connectionString);
//                 await connection.OpenAsync();

//                 using var command = new SqlCommand("Get_Subhire_Equipment_Summary", connection)
//                 {
//                     CommandType = CommandType.StoredProcedure
//                 };
//                 command.Parameters.AddWithValue("@entityno", entityNo);

//                 var summary = new List<SubhireEquipmentSummary>();
//                 using var reader = await command.ExecuteReaderAsync();
//                 while (await reader.ReadAsync())
//                 {
//                     summary.Add(new SubhireEquipmentSummary
//                     {
//                         VendorNo = reader["vendno"].ToString(),
//                         VendorName = reader["vendname"].ToString(),
//                         SiteNo = reader["siteno"].ToString(),
//                         TotalItems = Convert.ToInt32(reader["totalitems"]),
//                         TotalQuantity = Convert.ToInt32(reader["totalquantity"]),
//                         TotalValue = Convert.ToDecimal(reader["totalvalue"]),
//                         Status = reader["status"].ToString(),
//                         PONumber = reader["ponumber"] != DBNull.Value ? Convert.ToInt32(reader["ponumber"]) : null
//                     });
//                 }

//                 return Ok(new ApiResponse<List<SubhireEquipmentSummary>>
//                 {
//                     Success = true,
//                     Message = "Subhire equipment summary retrieved successfully",
//                     Data = summary
//                 });
//             }
//             catch (Exception ex)
//             {
//                 _logger.LogError(ex, "Error retrieving subhire equipment summary for entity {EntityNo}", entityNo);
//                 return StatusCode(500, new ApiResponse<string>
//                 {
//                     Success = false,
//                     Message = "An error occurred while retrieving subhire equipment summary",
//                     Data = ex.Message
//                 });
//             }
//         }

//         /// <summary>
//         /// Gets vendor details for subhire equipment items
//         /// </summary>
//         /// <param name="vendorNo">The vendor number</param>
//         /// <returns>Vendor details including contact information</returns>
//         /// <response code="200">Returns the vendor details</response>
//         /// <response code="400">If the vendor number is invalid</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpGet("vendor/{vendorNo}")]
//         [ProducesResponseType(typeof(ApiResponse<VendorDetails>), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(typeof(ApiResponse<string>), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> GetVendorDetails(string vendorNo)
//         {
//             try
//             {
//                 if (string.IsNullOrWhiteSpace(vendorNo))
//                 {
//                     return BadRequest(new ApiResponse<string>
//                     {
//                         Success = false,
//                         Message = "Vendor number is required",
//                         Data = null
//                     });
//                 }

//                 var connectionString = _configuration.GetConnectionString("FinesseConnection");
//                 using var connection = new SqlConnection(connectionString);
//                 await connection.OpenAsync();

//                 using var command = new SqlCommand("Get_Vendor_Details", connection)
//                 {
//                     CommandType = CommandType.StoredProcedure
//                 };
//                 command.Parameters.AddWithValue("@vendno", vendorNo);

//                 using var reader = await command.ExecuteReaderAsync();
//                 if (!await reader.ReadAsync())
//                 {
//                     return NotFound(new ApiResponse<string>
//                     {
//                         Success = false,
//                         Message = $"Vendor {vendorNo} not found",
//                         Data = null
//                     });
//                 }

//                 var vendorDetails = new VendorDetails
//                 {
//                     VendorNo = reader["vendno"].ToString(),
//                     VendorName = reader["vendname"].ToString(),
//                     ContactName = reader["contactname"].ToString(),
//                     PhoneNumber = reader["phonenumber"].ToString(),
//                     Email = reader["email"].ToString(),
//                     Address = reader["address"].ToString(),
//                     City = reader["city"].ToString(),
//                     State = reader["state"].ToString(),
//                     ZipCode = reader["zipcode"].ToString(),
//                     Country = reader["country"].ToString()
//                 };

//                 return Ok(new ApiResponse<VendorDetails>
//                 {
//                     Success = true,
//                     Message = "Vendor details retrieved successfully",
//                     Data = vendorDetails
//                 });
//             }
//             catch (Exception ex)
//             {
//                 _logger.LogError(ex, "Error retrieving vendor details for vendor {VendorNo}", vendorNo);
//                 return StatusCode(500, new ApiResponse<string>
//                 {
//                     Success = false,
//                     Message = "An error occurred while retrieving vendor details",
//                     Data = ex.Message
//                 });
//             }
//         }

//         private async Task UpdateEquipmentSubhireRecords(SqlConnection connection, SqlTransaction transaction, List<SubhireEquipmentItem> items, int poNumber)
//         {
//             using var command = new SqlCommand("Update_Equipment_Subhire_Records", connection, transaction)
//             {
//                 CommandType = CommandType.StoredProcedure
//             };

//             command.Parameters.AddWithValue("@ponumber", poNumber);
//             command.Parameters.AddWithValue("@statuscode", "Confirmed");

//             var entityNoParam = command.Parameters.Add("@entityno", SqlDbType.VarChar, 20);
//             var vendorNoParam = command.Parameters.Add("@vendno", SqlDbType.VarChar, 20);
//             var siteNoParam = command.Parameters.Add("@siteno", SqlDbType.VarChar, 20);

//             foreach (var item in items)
//             {
//                 entityNoParam.Value = item.EntityNo;
//                 vendorNoParam.Value = item.VendorNo;
//                 siteNoParam.Value = item.SiteNo;

//                 await command.ExecuteNonQueryAsync();
//             }
//         }
//     }

//     public class CreateSubhirePORequest
//     {
//         [Required]
//         [MinLength(1)]
//         public List<SubhireEquipmentItem> Items { get; set; }
//     }

//     public class CreateSubhireTransferRequest
//     {
//         public List<SubhireEquipmentItem> Items { get; set; }
//     }

//     public class UpdateSubhireStatusRequest
//     {
//         public List<SubhireEquipmentItem> Items { get; set; }
//     }

//     public class SubhireEquipmentItem
//     {
//         [Required]
//         [StringLength(20)]
//         public string EntityNo { get; set; }

//         [Required]
//         [StringLength(20)]
//         public string VendorNo { get; set; }

//         [Required]
//         [StringLength(20)]
//         public string SiteNo { get; set; }

//         [Required]
//         [StringLength(50)]
//         public string EquipmentCode { get; set; }

//         [Required]
//         [StringLength(200)]
//         public string Description { get; set; }

//         [Range(1, int.MaxValue)]
//         public int Quantity { get; set; }

//         [StringLength(20)]
//         public string StatusCode { get; set; }

//         public int? PONumber { get; set; }
//     }

//     public class PurchaseOrderResult
//     {
//         public int PurchaseOrderNumber { get; set; }
//         public string EntityNo { get; set; }
//         public string VendorNo { get; set; }
//         public string SiteNo { get; set; }
//         public string Status { get; set; }
//         public List<SubhireEquipmentItem> Items { get; set; }
//     }

//     public class SubhireTransferResult
//     {
//         public int TransferId { get; set; }
//         public string EntityNo { get; set; }
//         public string VendorNo { get; set; }
//         public string SiteNo { get; set; }
//         public string EquipmentCode { get; set; }
//         public int Quantity { get; set; }
//         public int? PONumber { get; set; }
//         public string Status { get; set; }
//     }

//     public class SubhireEquipmentSummary
//     {
//         public string VendorNo { get; set; }
//         public string VendorName { get; set; }
//         public string SiteNo { get; set; }
//         public int TotalItems { get; set; }
//         public int TotalQuantity { get; set; }
//         public decimal TotalValue { get; set; }
//         public string Status { get; set; }
//         public int? PONumber { get; set; }
//     }

//     public class VendorDetails
//     {
//         public string VendorNo { get; set; }
//         public string VendorName { get; set; }
//         public string ContactName { get; set; }
//         public string PhoneNumber { get; set; }
//         public string Email { get; set; }
//         public string Address { get; set; }
//         public string City { get; set; }
//         public string State { get; set; }
//         public string ZipCode { get; set; }
//         public string Country { get; set; }
//     }

//     public class ApiResponse<T>
//     {
//         public bool Success { get; set; }
//         public string Message { get; set; }
//         public T Data { get; set; }
//     }
// } 