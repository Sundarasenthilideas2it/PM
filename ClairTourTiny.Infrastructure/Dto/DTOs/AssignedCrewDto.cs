using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for assigned crew information
/// </summary>
public class AssignedCrewDto
{
    /// <summary>
    /// The unique identifier of the assigned crew record
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this crew assignment is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The employee number of the assigned crew member
    /// </summary>
    public string EmployeeNo { get; set; } = null!;

    /// <summary>
    /// The name of the assigned crew member
    /// </summary>
    public string EmployeeName { get; set; } = null!;

    /// <summary>
    /// The job type of the assigned crew member
    /// </summary>
    public string JobType { get; set; } = null!;

    /// <summary>
    /// The start date of the assignment
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// The end date of the assignment
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// The status of the assignment
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// The daily rate for this assignment
    /// </summary>
    public decimal DailyRate { get; set; }

    /// <summary>
    /// The weekly rate for this assignment
    /// </summary>
    public decimal WeeklyRate { get; set; }

    /// <summary>
    /// Whether per diem is being paid
    /// </summary>
    public bool IsPerDiemPaid { get; set; }

    /// <summary>
    /// Whether per diem is billable
    /// </summary>
    public bool IsPerDiemBillable { get; set; }

    /// <summary>
    /// Any notes about this assignment
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this assignment was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this assignment
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 