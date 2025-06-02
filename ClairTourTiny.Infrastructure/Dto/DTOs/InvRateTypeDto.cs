using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for invoice rate type information
/// </summary>
public class InvRateTypeDto
{
    /// <summary>
    /// The unique identifier of the invoice rate type
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this invoice rate type is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The rate type code
    /// </summary>
    public string RateTypeCode { get; set; } = null!;

    /// <summary>
    /// The description of the rate type
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this rate type is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The default rate for this type
    /// </summary>
    public decimal? DefaultRate { get; set; }

    /// <summary>
    /// The default currency for this rate type
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The default tax code for this rate type
    /// </summary>
    public string? DefaultTaxCode { get; set; }

    /// <summary>
    /// The default markup percentage for this rate type
    /// </summary>
    public decimal? DefaultMarkupPercentage { get; set; }

    /// <summary>
    /// The billing frequency for this rate type
    /// </summary>
    public string? BillingFrequency { get; set; }

    /// <summary>
    /// The sort order for this rate type
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the rate type
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this rate type was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this rate type
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 