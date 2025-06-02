using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for vendor information
/// </summary>
public class VendorDto
{
    /// <summary>
    /// Vendor number
    /// </summary>
    public string VendNo { get; set; } = null!;

    /// <summary>
    /// Site number
    /// </summary>
    public string SiteNo { get; set; } = null!;

    /// <summary>
    /// Vendor name
    /// </summary>
    public string VendorName { get; set; } = null!;

    /// <summary>
    /// Currency code
    /// </summary>
    public string Currency { get; set; } = "USD";

    /// <summary>
    /// Rate amount
    /// </summary>
    public decimal Rate { get; set; }

    /// <summary>
    /// Rate type (D for Daily, etc.)
    /// </summary>
    public string RateType { get; set; } = "D";

    /// <summary>
    /// Two day week rate
    /// </summary>
    public decimal TwoDayWeek { get; set; }

    /// <summary>
    /// Three day week rate
    /// </summary>
    public decimal ThreeDayWeek { get; set; }

    /// <summary>
    /// Delivery rate
    /// </summary>
    public decimal DeliveryRate { get; set; }

    /// <summary>
    /// Return rate
    /// </summary>
    public decimal ReturnRate { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Phone number
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Contact person
    /// </summary>
    public string? Contact { get; set; }

    /// <summary>
    /// Email address
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Mobile number
    /// </summary>
    public string? Mobile { get; set; }
}

/// <summary>
/// Data transfer object for vendor address information
/// </summary>
public class VendorAddressDto
{
    /// <summary>
    /// Site number
    /// </summary>
    public string SiteNo { get; set; } = null!;

    /// <summary>
    /// Vendor name
    /// </summary>
    public string VendorName { get; set; } = null!;

    /// <summary>
    /// Contact person
    /// </summary>
    public string? Contact { get; set; }

    /// <summary>
    /// Address line 1
    /// </summary>
    public string? Address1 { get; set; }

    /// <summary>
    /// Address line 2
    /// </summary>
    public string? Address2 { get; set; }

    /// <summary>
    /// Address line 3
    /// </summary>
    public string? Address3 { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Zip code
    /// </summary>
    public string? ZipCode { get; set; }
}

/// <summary>
/// Request DTO for adding a new vendor to known vendors
/// </summary>
public class AddKnownVendorRequestDto
{
    /// <summary>
    /// Part number
    /// </summary>
    public string PartNo { get; set; } = null!;

    /// <summary>
    /// Vendor number
    /// </summary>
    public string VendNo { get; set; } = null!;

    /// <summary>
    /// Site number
    /// </summary>
    public string SiteNo { get; set; } = null!;

    /// <summary>
    /// Vendor name
    /// </summary>
    public string VendorName { get; set; } = null!;

    /// <summary>
    /// Notes
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Currency code
    /// </summary>
    public string Currency { get; set; } = "USD";

    /// <summary>
    /// Rate amount
    /// </summary>
    public decimal Rate { get; set; }

    /// <summary>
    /// Rate type
    /// </summary>
    public string RateType { get; set; } = "D";

    /// <summary>
    /// Delivery rate
    /// </summary>
    public decimal DeliveryRate { get; set; }

    /// <summary>
    /// Return rate
    /// </summary>
    public decimal ReturnRate { get; set; }
} 