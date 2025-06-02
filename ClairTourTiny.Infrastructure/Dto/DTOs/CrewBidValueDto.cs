using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for crew bid value information
/// </summary>
public class CrewBidValueDto
{
    /// <summary>
    /// The unique identifier of the crew bid value
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this crew bid value is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The job type for this bid value
    /// </summary>
    public string JobType { get; set; } = null!;

    /// <summary>
    /// The daily rate for this bid value
    /// </summary>
    public decimal DailyRate { get; set; }

    /// <summary>
    /// The weekly rate for this bid value
    /// </summary>
    public decimal WeeklyRate { get; set; }

    /// <summary>
    /// The overtime rate for this bid value
    /// </summary>
    public decimal OvertimeRate { get; set; }

    /// <summary>
    /// The per diem rate for this bid value
    /// </summary>
    public decimal PerDiemRate { get; set; }

    /// <summary>
    /// The currency for this bid value
    /// </summary>
    public string Currency { get; set; } = null!;

    /// <summary>
    /// The exchange rate used
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// The date of the exchange rate
    /// </summary>
    public DateTime? ExchangeRateDate { get; set; }

    /// <summary>
    /// Whether this bid value is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The effective start date of this bid value
    /// </summary>
    public DateTime? EffectiveStartDate { get; set; }

    /// <summary>
    /// The effective end date of this bid value
    /// </summary>
    public DateTime? EffectiveEndDate { get; set; }

    /// <summary>
    /// Any notes about this bid value
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