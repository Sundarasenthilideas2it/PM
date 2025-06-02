using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for job type information
/// </summary>
public class JobTypeDto
{
    /// <summary>
    /// The unique identifier of the job type
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this job type is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The job type code
    /// </summary>
    public string JobTypeCode { get; set; } = null!;

    /// <summary>
    /// The description of the job type
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this job type is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The default daily rate for this job type
    /// </summary>
    public decimal? DefaultDailyRate { get; set; }

    /// <summary>
    /// The default weekly rate for this job type
    /// </summary>
    public decimal? DefaultWeeklyRate { get; set; }

    /// <summary>
    /// The default overtime rate for this job type
    /// </summary>
    public decimal? DefaultOvertimeRate { get; set; }

    /// <summary>
    /// The default per diem rate for this job type
    /// </summary>
    public decimal? DefaultPerDiemRate { get; set; }

    /// <summary>
    /// The default currency for this job type
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The category of the job type
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Any notes about the job type
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this job type was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this job type
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 