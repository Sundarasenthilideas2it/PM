using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for favorite project information
/// </summary>
public class FavoriteProjectDto
{
    /// <summary>
    /// The unique identifier of the favorite project record
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number of the project
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The user who favorited the project
    /// </summary>
    public string UserId { get; set; } = null!;

    /// <summary>
    /// The date the project was favorited
    /// </summary>
    public DateTime FavoriteDate { get; set; }

    /// <summary>
    /// The description of the project
    /// </summary>
    public string ProjectDescription { get; set; } = null!;

    /// <summary>
    /// The start date of the project
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The end date of the project
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// The billing company of the project
    /// </summary>
    public string? BillingCompany { get; set; }

    /// <summary>
    /// The agency of the project
    /// </summary>
    public string? Agency { get; set; }

    /// <summary>
    /// The date this favorite was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this favorite
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 