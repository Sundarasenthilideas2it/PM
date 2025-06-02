using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for bill schedule information
/// </summary>
public class BillScheduleDto
{
    /// <summary>
    /// The unique identifier of the bill schedule
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this bill schedule is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The schedule code
    /// </summary>
    public string ScheduleCode { get; set; } = null!;

    /// <summary>
    /// The description of the schedule
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this schedule is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The frequency of billing
    /// </summary>
    public string BillingFrequency { get; set; } = null!;

    /// <summary>
    /// The day of the month for billing
    /// </summary>
    public int? BillingDay { get; set; }

    /// <summary>
    /// The day of the week for billing
    /// </summary>
    public string? BillingDayOfWeek { get; set; }

    /// <summary>
    /// The number of days before the event for billing
    /// </summary>
    public int? DaysBeforeEvent { get; set; }

    /// <summary>
    /// The number of days after the event for billing
    /// </summary>
    public int? DaysAfterEvent { get; set; }

    /// <summary>
    /// The default payment terms
    /// </summary>
    public string? DefaultPaymentTerms { get; set; }

    /// <summary>
    /// The default currency
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The sort order for this schedule
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the schedule
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this schedule was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this schedule
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 