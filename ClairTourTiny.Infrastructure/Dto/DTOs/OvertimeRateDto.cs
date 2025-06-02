using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for overtime rate information
/// </summary>
public class OvertimeRateDto
{
    /// <summary>
    /// The unique identifier of the overtime rate
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this overtime rate is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The rate code
    /// </summary>
    public string RateCode { get; set; } = null!;

    /// <summary>
    /// The description of the overtime rate
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this overtime rate is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The multiplier for the overtime rate
    /// </summary>
    public decimal? Multiplier { get; set; }

    /// <summary>
    /// The minimum hours required for overtime
    /// </summary>
    public decimal? MinimumHours { get; set; }

    /// <summary>
    /// The default currency for the overtime rate
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The default tax code for overtime
    /// </summary>
    public string? DefaultTaxCode { get; set; }

    /// <summary>
    /// The sort order for this overtime rate
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the overtime rate
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this overtime rate was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this overtime rate
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 