using System.Collections.Generic;
using System.Threading.Tasks;
using ClairTourTiny.Infrastructure.Dto.DTOs;

namespace ClairTourTiny.Core.Interfaces;

/// <summary>
/// Interface for vendor-related operations
/// </summary>
public interface IVendorService
{
    /// <summary>
    /// Gets known vendors for a specific part number
    /// </summary>
    /// <param name="partNo">The part number to get vendors for</param>
    /// <returns>List of known vendors for the part</returns>
    Task<IEnumerable<VendorDto>> GetKnownVendorsAsync(string partNo);

    /// <summary>
    /// Gets vendor addresses for a specific vendor
    /// </summary>
    /// <param name="vendNo">The vendor number to get addresses for</param>
    /// <returns>List of vendor addresses</returns>
    Task<IEnumerable<VendorAddressDto>> GetVendorAddressesAsync(string vendNo);

    /// <summary>
    /// Adds a new vendor to the known vendors list
    /// </summary>
    /// <param name="request">The vendor information to add</param>
    /// <returns>True if successful, false otherwise</returns>
    Task<bool> AddKnownVendorAsync(AddKnownVendorRequestDto request);

    /// <summary>
    /// Checks if a vendor is already in the known vendors list
    /// </summary>
    /// <param name="partNo">The part number</param>
    /// <param name="vendNo">The vendor number</param>
    /// <param name="siteNo">The site number</param>
    /// <returns>True if the vendor is known, false otherwise</returns>
    Task<bool> IsKnownVendorAsync(string partNo, string vendNo, string siteNo);

    /// <summary>
    /// Gets all available subhire status codes
    /// </summary>
    /// <returns>List of subhire status codes with their descriptions and properties</returns>
    Task<IEnumerable<EquipmentSubhireStatusDto>> GetSubhireStatusesAsync();

    /// <summary>
    /// Gets all available rate types for subhires
    /// </summary>
    /// <returns>List of rate types with their descriptions</returns>
    Task<IEnumerable<RateTypeDto>> GetRateTypesAsync();
} 