using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for phase information
/// </summary>
public class PhaseDto
{
    /// <summary>
    /// The unique identifier of the phase
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this phase is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The phase code
    /// </summary>
    public string PhaseCode { get; set; } = null!;

    /// <summary>
    /// The description of the phase
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this phase is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The parent phase code if this is a sub-phase
    /// </summary>
    public string? ParentPhaseCode { get; set; }

    /// <summary>
    /// The phase level in the hierarchy
    /// </summary>
    public int? PhaseLevel { get; set; }

    /// <summary>
    /// The default duration in days
    /// </summary>
    public int? DefaultDuration { get; set; }

    /// <summary>
    /// The default currency for this phase
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The default tax code for this phase
    /// </summary>
    public string? DefaultTaxCode { get; set; }

    /// <summary>
    /// The default markup percentage for this phase
    /// </summary>
    public decimal? DefaultMarkupPercentage { get; set; }

    /// <summary>
    /// The color code for this phase
    /// </summary>
    public string? ColorCode { get; set; }

    /// <summary>
    /// The sort order for this phase
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Whether this phase requires approval
    /// </summary>
    public bool RequiresApproval { get; set; }

    /// <summary>
    /// Whether this phase is billable
    /// </summary>
    public bool IsBillable { get; set; }

    /// <summary>
    /// The default billing schedule for this phase
    /// </summary>
    public string? DefaultBillingSchedule { get; set; }

    /// <summary>
    /// Any notes about the phase
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this phase was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this phase
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 