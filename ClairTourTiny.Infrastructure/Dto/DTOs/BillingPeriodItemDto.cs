using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for billing period item information
/// </summary>
public class BillingPeriodItemDto
{
    /// <summary>
    /// The unique identifier of the billing period item
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this billing period item is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The billing period ID this item is associated with
    /// </summary>
    public int BillingPeriodId { get; set; }

    /// <summary>
    /// The item code
    /// </summary>
    public string ItemCode { get; set; } = null!;

    /// <summary>
    /// The description of the billing item
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this billing item is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The quantity for this billing item
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// The unit price for this billing item
    /// </summary>
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// The currency for this billing item
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// The tax code for this billing item
    /// </summary>
    public string? TaxCode { get; set; }

    /// <summary>
    /// The discount percentage for this billing item
    /// </summary>
    public decimal? DiscountPercentage { get; set; }

    /// <summary>
    /// The markup percentage for this billing item
    /// </summary>
    public decimal? MarkupPercentage { get; set; }

    /// <summary>
    /// The sort order for this billing item
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the billing item
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this billing item was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this billing item
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 