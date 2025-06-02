using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for crew position information
/// </summary>
public class CrewPositionDto
{
    /// <summary>
    /// The unique identifier of the crew position
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this crew position is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The job type for this position
    /// </summary>
    public string JobType { get; set; } = null!;

    /// <summary>
    /// The number of positions needed
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// The daily rate for this position
    /// </summary>
    public decimal DailyRate { get; set; }

    /// <summary>
    /// The weekly rate for this position
    /// </summary>
    public decimal WeeklyRate { get; set; }

    /// <summary>
    /// The status of this position
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// Any notes about this position
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this position was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this position
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 