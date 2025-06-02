using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for customer billing address information
/// </summary>
public class CustomerBillingAddressDto
{
    /// <summary>
    /// The unique identifier of the billing address
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this billing address is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The customer ID this billing address is associated with
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// The address line 1
    /// </summary>
    public string AddressLine1 { get; set; } = null!;

    /// <summary>
    /// The address line 2
    /// </summary>
    public string? AddressLine2 { get; set; }

    /// <summary>
    /// The city
    /// </summary>
    public string City { get; set; } = null!;

    /// <summary>
    /// The state/province
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// The postal code
    /// </summary>
    public string PostalCode { get; set; } = null!;

    /// <summary>
    /// The country
    /// </summary>
    public string Country { get; set; } = null!;

    /// <summary>
    /// Whether this is the default billing address
    /// </summary>
    public bool IsDefault { get; set; }

    /// <summary>
    /// The contact name for this address
    /// </summary>
    public string? ContactName { get; set; }

    /// <summary>
    /// The contact phone number for this address
    /// </summary>
    public string? ContactPhone { get; set; }

    /// <summary>
    /// The contact email for this address
    /// </summary>
    public string? ContactEmail { get; set; }

    /// <summary>
    /// Any notes about the billing address
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this billing address was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this billing address
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 