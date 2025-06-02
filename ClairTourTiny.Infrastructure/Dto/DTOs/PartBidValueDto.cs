using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for part bid value information
/// </summary>
public class PartBidValueDto
{
    /// <summary>
    /// The unique identifier of the part bid value
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this part bid value is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The part ID this bid value is associated with
    /// </summary>
    public int PartId { get; set; }

    /// <summary>
    /// The bid value code
    /// </summary>
    public string ValueCode { get; set; } = null!;

    /// <summary>
    /// The description of the bid value
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this bid value is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The bid value amount
    /// </summary>
    public decimal? Value { get; set; }

    /// <summary>
    /// The currency for the bid value
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// The tax code for the bid value
    /// </summary>
    public string? TaxCode { get; set; }

    /// <summary>
    /// The markup percentage
    /// </summary>
    public decimal? MarkupPercentage { get; set; }

    /// <summary>
    /// The quantity for this bid value
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// The unit of measure
    /// </summary>
    public string? UnitOfMeasure { get; set; }

    /// <summary>
    /// The sort order for this bid value
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the bid value
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this bid value was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this bid value
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 