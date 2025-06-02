using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for rate type information
/// </summary>
public class RateTypeDto
{
    /// <summary>
    /// The rate type code (e.g., "D" for Daily, "W" for Weekly)
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// The description of the rate type
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this rate type is active
    /// </summary>
    public bool IsActive { get; set; } = true;

    /// <summary>
    /// The sort order for display
    /// </summary>
    public int SortOrder { get; set; }

    /// <summary>
    /// Whether this rate type is for daily rates
    /// </summary>
    public bool IsDaily { get; set; }

    /// <summary>
    /// Whether this rate type is for weekly rates
    /// </summary>
    public bool IsWeekly { get; set; }

    /// <summary>
    /// Whether this rate type is for monthly rates
    /// </summary>
    public bool IsMonthly { get; set; }

    /// <summary>
    /// The number of days this rate type represents (e.g., 1 for daily, 7 for weekly)
    /// </summary>
    public int DaysPerUnit { get; set; }
} 