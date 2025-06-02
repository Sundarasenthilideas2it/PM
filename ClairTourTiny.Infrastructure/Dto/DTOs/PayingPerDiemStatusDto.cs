using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for paying per diem status information
/// </summary>
public class PayingPerDiemStatusDto
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
    /// The default per diem rate
    /// </summary>
    public decimal? DefaultRate { get; set; }

    /// <summary>
    /// The default currency for per diem payments
    /// </summary>
    public string? DefaultCurrency { get; set; }

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