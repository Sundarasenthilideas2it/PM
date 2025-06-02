using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for employee information
/// </summary>
public class EmployeeDto
{
    /// <summary>
    /// The unique identifier of the employee
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this employee is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The employee number
    /// </summary>
    public string EmployeeNo { get; set; } = null!;

    /// <summary>
    /// The first name of the employee
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// The last name of the employee
    /// </summary>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// The email address of the employee
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// The phone number of the employee
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// The job type of the employee
    /// </summary>
    public string JobType { get; set; } = null!;

    /// <summary>
    /// The status of the employee
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// The hire date of the employee
    /// </summary>
    public DateTime? HireDate { get; set; }

    /// <summary>
    /// The termination date of the employee
    /// </summary>
    public DateTime? TerminationDate { get; set; }

    /// <summary>
    /// The default daily rate for the employee
    /// </summary>
    public decimal? DefaultDailyRate { get; set; }

    /// <summary>
    /// The default weekly rate for the employee
    /// </summary>
    public decimal? DefaultWeeklyRate { get; set; }

    /// <summary>
    /// The default overtime rate for the employee
    /// </summary>
    public decimal? DefaultOvertimeRate { get; set; }

    /// <summary>
    /// The default per diem rate for the employee
    /// </summary>
    public decimal? DefaultPerDiemRate { get; set; }

    /// <summary>
    /// The default currency for the employee
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// Any notes about the employee
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this employee record was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this employee record
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 