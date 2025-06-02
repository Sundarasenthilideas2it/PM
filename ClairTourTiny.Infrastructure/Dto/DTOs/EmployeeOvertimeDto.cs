using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for employee overtime information
/// </summary>
public class EmployeeOvertimeDto
{
    /// <summary>
    /// The unique identifier of the overtime record
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this overtime is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The employee number
    /// </summary>
    public string EmployeeNo { get; set; } = null!;

    /// <summary>
    /// The employee name
    /// </summary>
    public string EmployeeName { get; set; } = null!;

    /// <summary>
    /// The job type
    /// </summary>
    public string JobType { get; set; } = null!;

    /// <summary>
    /// The overtime rate
    /// </summary>
    public decimal OvertimeRate { get; set; }

    /// <summary>
    /// The overtime hours
    /// </summary>
    public decimal OvertimeHours { get; set; }

    /// <summary>
    /// The overtime amount
    /// </summary>
    public decimal OvertimeAmount { get; set; }

    /// <summary>
    /// The date of the overtime
    /// </summary>
    public DateTime OvertimeDate { get; set; }

    /// <summary>
    /// The status of the overtime
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// Any notes about the overtime
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The user who created the overtime record
    /// </summary>
    public string CreatedBy { get; set; } = null!;

    /// <summary>
    /// The date the overtime record was created
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// The date the overtime record was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified the overtime record
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 