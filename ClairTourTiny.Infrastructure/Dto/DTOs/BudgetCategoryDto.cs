using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for budget category information
/// </summary>
public class BudgetCategoryDto
{
    /// <summary>
    /// The unique identifier of the budget category
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this budget category is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The category code
    /// </summary>
    public string CategoryCode { get; set; } = null!;

    /// <summary>
    /// The description of the category
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this category is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The parent category code
    /// </summary>
    public string? ParentCategoryCode { get; set; }

    /// <summary>
    /// The level of this category in the hierarchy
    /// </summary>
    public int? CategoryLevel { get; set; }

    /// <summary>
    /// The sort order for this category
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// The default markup percentage for this category
    /// </summary>
    public decimal? DefaultMarkupPercentage { get; set; }

    /// <summary>
    /// The default currency for this category
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// Any notes about the category
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this category was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this category
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 