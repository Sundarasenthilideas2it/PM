using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for project pricing value information
/// </summary>
public class ProjectPricingValueDto
{
    /// <summary>
    /// The unique identifier of the project pricing value
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this project pricing value is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The project ID this pricing value is associated with
    /// </summary>
    public int ProjectId { get; set; }

    /// <summary>
    /// The pricing value code
    /// </summary>
    public string ValueCode { get; set; } = null!;

    /// <summary>
    /// The description of the pricing value
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this pricing value is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The value amount
    /// </summary>
    public decimal? Value { get; set; }

    /// <summary>
    /// The currency for the value
    /// </summary>
    public string? Currency { get; set; }

    /// <summary>
    /// The tax code for the value
    /// </summary>
    public string? TaxCode { get; set; }

    /// <summary>
    /// The markup percentage
    /// </summary>
    public decimal? MarkupPercentage { get; set; }

    /// <summary>
    /// The sort order for this pricing value
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the pricing value
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this pricing value was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this pricing value
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 