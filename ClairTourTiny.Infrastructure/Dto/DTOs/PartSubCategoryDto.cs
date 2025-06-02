using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for part subcategory information
/// </summary>
public class PartSubCategoryDto1
{
    /// <summary>
    /// The unique identifier of the part subcategory
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this part subcategory is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The subcategory code
    /// </summary>
    public string SubCategoryCode { get; set; } = null!;

    /// <summary>
    /// The description of the subcategory
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this subcategory is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The parent category code
    /// </summary>
    public string? ParentCategoryCode { get; set; }

    /// <summary>
    /// The level of this subcategory in the hierarchy
    /// </summary>
    public int? SubCategoryLevel { get; set; }

    /// <summary>
    /// The sort order for this subcategory
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// The default markup percentage for this subcategory
    /// </summary>
    public decimal? DefaultMarkupPercentage { get; set; }

    /// <summary>
    /// The default currency for this subcategory
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The default tax code for this subcategory
    /// </summary>
    public string? DefaultTaxCode { get; set; }

    /// <summary>
    /// Any notes about the subcategory
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this subcategory was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this subcategory
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 