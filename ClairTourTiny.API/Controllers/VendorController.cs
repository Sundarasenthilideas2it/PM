using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClairTourTiny.Core.Interfaces;
using ClairTourTiny.Infrastructure.Dto.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClairTourTiny.API.Controllers;

/// <summary>
/// Controller for managing vendor operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class VendorController : ControllerBase
{
    private readonly IVendorService _vendorService;
    private readonly ILogger<VendorController> _logger;

    public VendorController(IVendorService vendorService, ILogger<VendorController> logger)
    {
        _vendorService = vendorService;
        _logger = logger;
    }

    /// <summary>
    /// Gets known vendors for a specific part number
    /// </summary>
    /// <param name="partNo">The part number to get vendors for</param>
    /// <returns>List of known vendors for the part</returns>
    /// <response code="200">Returns the list of known vendors</response>
    /// <response code="400">If the part number is invalid</response>
    /// <response code="500">If there was an internal server error</response>
    [HttpGet("known-vendors/{partNo}")]
    [ProducesResponseType(typeof(IEnumerable<VendorDto>), 200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(500)]
    public async Task<ActionResult<IEnumerable<VendorDto>>> GetKnownVendors(string partNo)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(partNo))
            {
                return BadRequest("Part number is required");
            }

            var vendors = await _vendorService.GetKnownVendorsAsync(partNo);
            return Ok(vendors);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving known vendors for part {PartNo}", partNo);
            return StatusCode(500, "An error occurred while retrieving known vendors");
        }
    }

    /// <summary>
    /// Gets vendor addresses for a specific vendor
    /// </summary>
    /// <param name="vendNo">The vendor number to get addresses for</param>
    /// <returns>List of vendor addresses</returns>
    /// <response code="200">Returns the list of vendor addresses</response>
    /// <response code="400">If the vendor number is invalid</response>
    /// <response code="500">If there was an internal server error</response>
    [HttpGet("addresses/{vendNo}")]
    [ProducesResponseType(typeof(IEnumerable<VendorAddressDto>), 200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(500)]
    public async Task<ActionResult<IEnumerable<VendorAddressDto>>> GetVendorAddresses(string vendNo)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(vendNo))
            {
                return BadRequest("Vendor number is required");
            }

            var addresses = await _vendorService.GetVendorAddressesAsync(vendNo);
            return Ok(addresses);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving vendor addresses for vendor {VendNo}", vendNo);
            return StatusCode(500, "An error occurred while retrieving vendor addresses");
        }
    }

    /// <summary>
    /// Adds a new vendor to the known vendors list
    /// </summary>
    /// <param name="request">The vendor information to add</param>
    /// <returns>True if successful</returns>
    /// <response code="200">If the vendor was added successfully</response>
    /// <response code="400">If the request is invalid</response>
    /// <response code="500">If there was an internal server error</response>
    [HttpPost("known-vendors")]
    [ProducesResponseType(typeof(bool), 200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(500)]
    public async Task<ActionResult<bool>> AddKnownVendor([FromBody] AddKnownVendorRequestDto request)
    {
        try
        {
            if (request == null)
            {
                return BadRequest("Request body is required");
            }

            if (string.IsNullOrWhiteSpace(request.PartNo) || 
                string.IsNullOrWhiteSpace(request.VendNo) || 
                string.IsNullOrWhiteSpace(request.SiteNo))
            {
                return BadRequest("Part number, vendor number, and site number are required");
            }

            // Check if vendor is already known
            var isKnown = await _vendorService.IsKnownVendorAsync(request.PartNo, request.VendNo, request.SiteNo);
            if (isKnown)
            {
                return BadRequest("This vendor is already in the known vendors list");
            }

            var result = await _vendorService.AddKnownVendorAsync(request);
            return Ok(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error adding known vendor for part {PartNo}, vendor {VendNo}", 
                request?.PartNo, request?.VendNo);
            return StatusCode(500, "An error occurred while adding the known vendor");
        }
    }

    /// <summary>
    /// Checks if a vendor is already in the known vendors list
    /// </summary>
    /// <param name="partNo">The part number</param>
    /// <param name="vendNo">The vendor number</param>
    /// <param name="siteNo">The site number</param>
    /// <returns>True if the vendor is known, false otherwise</returns>
    /// <response code="200">Returns whether the vendor is known</response>
    /// <response code="400">If any of the parameters are invalid</response>
    /// <response code="500">If there was an internal server error</response>
    [HttpGet("known-vendors/check")]
    [ProducesResponseType(typeof(bool), 200)]
    [ProducesResponseType(400)]
    [ProducesResponseType(500)]
    public async Task<ActionResult<bool>> IsKnownVendor(
        [FromQuery] string partNo,
        [FromQuery] string vendNo,
        [FromQuery] string siteNo)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(partNo) || 
                string.IsNullOrWhiteSpace(vendNo) || 
                string.IsNullOrWhiteSpace(siteNo))
            {
                return BadRequest("Part number, vendor number, and site number are required");
            }

            var isKnown = await _vendorService.IsKnownVendorAsync(partNo, vendNo, siteNo);
            return Ok(isKnown);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error checking if vendor is known for part {PartNo}, vendor {VendNo}", 
                partNo, vendNo);
            return StatusCode(500, "An error occurred while checking if the vendor is known");
        }
    }

    /// <summary>
    /// Gets all available subhire status codes
    /// </summary>
    /// <returns>List of subhire status codes with their descriptions and properties</returns>
    /// <response code="200">Returns the list of status codes</response>
    /// <response code="500">If there was an internal server error</response>
    [HttpGet("subhire-statuses")]
    [ProducesResponseType(typeof(IEnumerable<EquipmentSubhireStatusDto>), 200)]
    [ProducesResponseType(500)]
    public async Task<ActionResult<IEnumerable<EquipmentSubhireStatusDto>>> GetSubhireStatuses()
    {
        try
        {
            var statuses = await _vendorService.GetSubhireStatusesAsync();
            return Ok(statuses);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving subhire statuses");
            return StatusCode(500, "An error occurred while retrieving subhire statuses");
        }
    }

    /// <summary>
    /// Gets all available rate types for subhires
    /// </summary>
    /// <returns>List of rate types with their descriptions</returns>
    /// <response code="200">Returns the list of rate types</response>
    /// <response code="500">If there was an internal server error</response>
    [HttpGet("rate-types")]
    [ProducesResponseType(typeof(IEnumerable<RateTypeDto>), 200)]
    [ProducesResponseType(500)]
    public async Task<ActionResult<IEnumerable<RateTypeDto>>> GetRateTypes()
    {
        try
        {
            var rateTypes = await _vendorService.GetRateTypesAsync();
            return Ok(rateTypes);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving rate types");
            return StatusCode(500, "An error occurred while retrieving rate types");
        }
    }
} 