using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for expense code information
/// </summary>
public class ExpenseCodeDto
{
    /// <summary>
    /// The unique identifier of the expense code
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this expense code is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The expense code
    /// </summary>
    public string ExpenseCode { get; set; } = null!;

    /// <summary>
    /// The description of the expense code
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this expense code is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The budget category this expense code belongs to
    /// </summary>
    public string? BudgetCategory { get; set; }

    /// <summary>
    /// The default unit price for this expense code
    /// </summary>
    public decimal? DefaultUnitPrice { get; set; }

    /// <summary>
    /// The default currency for this expense code
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The default tax code for this expense code
    /// </summary>
    public string? DefaultTaxCode { get; set; }

    /// <summary>
    /// The default markup percentage for this expense code
    /// </summary>
    public decimal? DefaultMarkupPercentage { get; set; }

    /// <summary>
    /// The sort order for this expense code
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the expense code
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this expense code was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this expense code
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 