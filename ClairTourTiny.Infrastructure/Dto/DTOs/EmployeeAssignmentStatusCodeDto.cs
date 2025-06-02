using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for employee assignment status code information
/// </summary>
public class EmployeeAssignmentStatusCodeDto
{
    /// <summary>
    /// The unique identifier of the status code
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this status code is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The status code
    /// </summary>
    public string StatusCode { get; set; } = null!;

    /// <summary>
    /// The description of the status code
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this status code is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The color code for this status
    /// </summary>
    public string? ColorCode { get; set; }

    /// <summary>
    /// The sort order for this status
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the status code
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this status code was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this status code
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 