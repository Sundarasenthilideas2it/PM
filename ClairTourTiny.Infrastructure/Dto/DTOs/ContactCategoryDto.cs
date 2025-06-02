using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for contact category information
/// </summary>
/// 

 
public class ContactCategoryDto
{
    // /// <summary>
    // /// The unique identifier of the contact category
    // /// </summary>
    // public int Id { get; set; }

    // /// <summary>
    // /// The entity number this contact category is associated with
    // /// </summary>
    // public string EntityNo { get; set; } = null!;

    // /// <summary>
    // /// The category code
    // /// </summary>
    // public string CategoryCode { get; set; } = null!;

    // /// <summary>
    // /// The description of the category
    // /// </summary>
    // public string Description { get; set; } = null!;

    // /// <summary>
    // /// Whether this category is active
    // /// </summary>
    // public bool IsActive { get; set; }

    // /// <summary>
    // /// The parent category code
    // /// </summary>
    // public string? ParentCategoryCode { get; set; }

    // /// <summary>
    // /// The level of this category in the hierarchy
    // /// </summary>
    // public int? CategoryLevel { get; set; }

    // /// <summary>
    // /// The sort order for this category
    // /// </summary>
    // public int? SortOrder { get; set; }

    // /// <summary>
    // /// The color code for this category
    // /// </summary>
    // public string? ColorCode { get; set; }

    // /// <summary>
    // /// Whether this category is for internal contacts
    // /// </summary>
    // public bool IsInternal { get; set; }

    // /// <summary>
    // /// Whether this category is for external contacts
    // /// </summary>
    // public bool IsExternal { get; set; }

    // /// <summary>
    // /// Any notes about the category
    // /// </summary>
    // public string? Notes { get; set; }

    // /// <summary>
    // /// The date this category was last modified
    // /// </summary>
    // public DateTime? LastModifiedDate { get; set; }

    // /// <summary>
    // /// The user who last modified this category
    // /// </summary>
    // public string? LastModifiedBy { get; set; }

    public int id_ContactCategory { get; set; }
    public string ContactCategory { get; set; }
    public int SortOrder { get; set; }


} 