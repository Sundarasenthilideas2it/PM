// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using System.ComponentModel.DataAnnotations;
// using ClairTourTiny.Core.Interfaces;
// using ClairTourTiny.Core.Models;

// namespace ClairTourTiny.API.Controllers
// {
//     /// <summary>
//     /// Controller for managing file explorer operations
//     /// </summary>
//     [ApiController]
//     [Route("api/[controller]")]
//     [Produces("application/json")]
//     [ApiExplorerSettings(GroupName = "v1")]
//     public class ProjectFileExplorerController : ControllerBase
//     {
//         private readonly IFileExplorerService _fileExplorerService;

//         public ProjectFileExplorerController(IFileExplorerService fileExplorerService)
//         {
//             _fileExplorerService = fileExplorerService;
//         }

//         /// <summary>
//         /// Gets the root directory path for Finesse data
//         /// </summary>
//         /// <returns>The root directory path</returns>
//         /// <response code="200">Returns the root directory path</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpGet("finesse-data-root")]
//         [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> GetFinesseDataRootDirectory()
//         {
//             try
//             {
//                 var rootDirectory = await _fileExplorerService.GetFinesseDataRootDirectory();
//                 return Ok(rootDirectory);
//             }
//             catch (Exception ex)
//             {
//                 return StatusCode(StatusCodes.Status500InternalServerError, 
//                     new ErrorResponse { Message = ex.Message });
//             }
//         }

//         /// <summary>
//         /// Gets the file path for project attachments
//         /// </summary>
//         /// <param name="entityNo">The entity number</param>
//         /// <param name="attachmentTypeCode">The attachment type code</param>
//         /// <returns>The file path for project attachments</returns>
//         /// <response code="200">Returns the file path</response>
//         /// <response code="400">If the entity or attachment type is not found</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpGet("project-attachment-path")]
//         [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> GetProjectAttachmentFilePath(
//             [FromQuery] string entityNo,
//             [FromQuery] string attachmentTypeCode)
//         {
//             try
//             {
//                 var filePath = await _fileExplorerService.GetProjectAttachmentFilePath(entityNo, attachmentTypeCode);
//                 return Ok(filePath);
//             }
//             catch (Exception ex) when (ex.Message.Contains("not found"))
//             {
//                 return BadRequest(new ErrorResponse { Message = ex.Message });
//             }
//             catch (Exception ex)
//             {
//                 return StatusCode(StatusCodes.Status500InternalServerError, 
//                     new ErrorResponse { Message = ex.Message });
//             }
//         }

//         /// <summary>
//         /// Gets the folder path for employee attachments
//         /// </summary>
//         /// <param name="empNo">The employee number</param>
//         /// <param name="attachmentTypeCode">The attachment type code</param>
//         /// <returns>The folder path for employee attachments</returns>
//         /// <response code="200">Returns the folder path</response>
//         /// <response code="400">If the employee or attachment type is not found</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpGet("employee-attachment-path")]
//         [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> GetEmployeeAttachmentFolderPath(
//             [FromQuery] string empNo,
//             [FromQuery] string attachmentTypeCode)
//         {
//             try
//             {
//                 var folderPath = await _fileExplorerService.GetEmployeeAttachmentFolderPath(empNo, attachmentTypeCode);
//                 return Ok(folderPath);
//             }
//             catch (Exception ex) when (ex.Message.Contains("not found"))
//             {
//                 return BadRequest(new ErrorResponse { Message = ex.Message });
//             }
//             catch (Exception ex)
//             {
//                 return StatusCode(StatusCodes.Status500InternalServerError, 
//                     new ErrorResponse { Message = ex.Message });
//             }
//         }

//         /// <summary>
//         /// Gets the folder path for customer order attachments
//         /// </summary>
//         /// <param name="orderNo">The order number</param>
//         /// <param name="attachmentTypeCode">The attachment type code</param>
//         /// <returns>A dictionary containing the GUID and folder path</returns>
//         /// <response code="200">Returns the GUID and folder path</response>
//         /// <response code="400">If the order or attachment type is not found</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpGet("customer-order-attachment-path")]
//         [ProducesResponseType(typeof(Dictionary<string, string>), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> GetCustomerOrderAttachmentFolderPath(
//             [FromQuery] string orderNo,
//             [FromQuery] string attachmentTypeCode)
//         {
//             try
//             {
//                 var result = await _fileExplorerService.GetCustomerOrderAttachmentFolderPath(orderNo, attachmentTypeCode);
//                 return Ok(result);
//             }
//             catch (Exception ex) when (ex.Message.Contains("not found"))
//             {
//                 return BadRequest(new ErrorResponse { Message = ex.Message });
//             }
//             catch (Exception ex)
//             {
//                 return StatusCode(StatusCodes.Status500InternalServerError, 
//                     new ErrorResponse { Message = ex.Message });
//             }
//         }

//         /// <summary>
//         /// Gets the root phase number from a full entity number
//         /// </summary>
//         /// <param name="fullEntityNo">The full entity number</param>
//         /// <returns>The root phase number</returns>
//         /// <response code="200">Returns the root phase number</response>
//         /// <response code="400">If the entity number is invalid</response>
//         [HttpGet("project-root-phase")]
//         [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
//         public IActionResult GetProjectRootPhaseNumber([FromQuery] string fullEntityNo)
//         {
//             try
//             {
//                 var rootPhaseNumber = _fileExplorerService.GetProjectRootPhaseNumber(fullEntityNo);
//                 return Ok(rootPhaseNumber);
//             }
//             catch (Exception ex)
//             {
//                 return BadRequest(new ErrorResponse { Message = ex.Message });
//             }
//         }

//         /// <summary>
//         /// Cleans a file or folder name by removing invalid characters
//         /// </summary>
//         /// <param name="filePath">The file or folder name to clean</param>
//         /// <returns>The cleaned file or folder name</returns>
//         /// <response code="200">Returns the cleaned name</response>
//         /// <response code="400">If the file path is invalid</response>
//         [HttpGet("clean-name")]
//         [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
//         public IActionResult CleanFileOrFolderName([FromQuery] string filePath)
//         {
//             try
//             {
//                 var cleanName = _fileExplorerService.CleanFileOrFolderName(filePath);
//                 return Ok(cleanName);
//             }
//             catch (Exception ex)
//             {
//                 return BadRequest(new ErrorResponse { Message = ex.Message });
//             }
//         }

//         /// <summary>
//         /// Gets the default root path for an attachment category
//         /// </summary>
//         /// <param name="attachmentCategory">The attachment category</param>
//         /// <returns>The default root path</returns>
//         /// <response code="200">Returns the default root path</response>
//         /// <response code="400">If the attachment category is not found</response>
//         /// <response code="500">If there was an internal server error</response>
//         [HttpGet("default-root-path")]
//         [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
//         [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status500InternalServerError)]
//         public async Task<IActionResult> GetDefaultRootPathForAttachmentCategory(
//             [FromQuery] string attachmentCategory)
//         {
//             try
//             {
//                 var rootPath = await _fileExplorerService.GetDefaultRootPathForAttachmentCategory(attachmentCategory);
//                 if (string.IsNullOrEmpty(rootPath))
//                 {
//                     return BadRequest(new ErrorResponse { Message = "Attachment category not found" });
//                 }
//                 return Ok(rootPath);
//             }
//             catch (Exception ex)
//             {
//                 return StatusCode(StatusCodes.Status500InternalServerError, 
//                     new ErrorResponse { Message = ex.Message });
//             }
//         }
//     }
// } 