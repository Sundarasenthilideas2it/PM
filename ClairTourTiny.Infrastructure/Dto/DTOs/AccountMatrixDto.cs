using System;
//sd
namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for account matrix information
/// </summary>
public class AccountMatrixDto
{
    /// <summary>
    /// The unique identifier of the account matrix
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this account matrix is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The matrix code
    /// </summary>
    public string MatrixCode { get; set; } = null!;

    /// <summary>
    /// The description of the account matrix
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this account matrix is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The default account number
    /// </summary>
    public string? DefaultAccountNumber { get; set; }

    /// <summary>
    /// The default cost center
    /// </summary>
    public string? DefaultCostCenter { get; set; }

    /// <summary>
    /// The default department
    /// </summary>
    public string? DefaultDepartment { get; set; }

    /// <summary>
    /// The default project code
    /// </summary>
    public string? DefaultProjectCode { get; set; }

    /// <summary>
    /// The sort order for this account matrix
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the account matrix
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this account matrix was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this account matrix
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 