using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for per diem billable status information
/// </summary>
public class IsPerDiemBillableStatusDto
{
    /// <summary>
    /// The unique identifier of the status
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this status is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The status code
    /// </summary>
    public string StatusCode { get; set; } = null!;

    /// <summary>
    /// The description of the status
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this status is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The sort order for this status
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// The default tax code for billable per diem
    /// </summary>
    public string? DefaultTaxCode { get; set; }

    /// <summary>
    /// The default markup percentage for billable per diem
    /// </summary>
    public decimal? DefaultMarkupPercentage { get; set; }

    /// <summary>
    /// Any notes about the status
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this status was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this status
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 