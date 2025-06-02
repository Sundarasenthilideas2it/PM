using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for user information
/// </summary>
public class UserInfoDto
{
    /// <summary>
    /// The unique identifier of the user
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this user is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The username
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// The user's email address
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// The user's first name
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// The user's last name
    /// </summary>
    public string LastName { get; set; } = null!;

    /// <summary>
    /// Whether this user is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The user's role
    /// </summary>
    public string? Role { get; set; }

    /// <summary>
    /// The user's department
    /// </summary>
    public string? Department { get; set; }

    /// <summary>
    /// The user's phone number
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// The user's employee ID
    /// </summary>
    public string? EmployeeId { get; set; }

    /// <summary>
    /// The date this user was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this user
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 