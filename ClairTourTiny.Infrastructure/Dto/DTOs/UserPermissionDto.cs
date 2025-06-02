using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for user permission information
/// </summary>
public class UserPermissionDto
{
    /// <summary>
    /// The unique identifier of the user permission
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this user permission is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The permission code
    /// </summary>
    public string PermissionCode { get; set; } = null!;

    /// <summary>
    /// The description of the permission
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this permission is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The permission level
    /// </summary>
    public int? PermissionLevel { get; set; }

    /// <summary>
    /// The module this permission belongs to
    /// </summary>
    public string? Module { get; set; }

    /// <summary>
    /// The submodule this permission belongs to
    /// </summary>
    public string? SubModule { get; set; }

    /// <summary>
    /// The sort order for this permission
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the permission
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this permission was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this permission
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 