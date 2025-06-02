using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for production schedule event type information
/// </summary>
public class ProductionScheduleEventTypeDto
{
    /// <summary>
    /// The unique identifier of the event type
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this event type is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The event type code
    /// </summary>
    public string EventTypeCode { get; set; } = null!;

    /// <summary>
    /// The description of the event type
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this event type is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The color code for this event type
    /// </summary>
    public string? ColorCode { get; set; }

    /// <summary>
    /// The sort order for this event type
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// The default duration in hours
    /// </summary>
    public int? DefaultDuration { get; set; }

    /// <summary>
    /// Whether this event type requires crew
    /// </summary>
    public bool RequiresCrew { get; set; }

    /// <summary>
    /// Whether this event type requires equipment
    /// </summary>
    public bool RequiresEquipment { get; set; }

    /// <summary>
    /// Any notes about the event type
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this event type was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this event type
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 