using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for project summary information
/// </summary>
public class ProjectSummaryDto
{
    /// <summary>
    /// The entity number of the project
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The description of the project
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// The start date of the project
    /// </summary>
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// The end date of the project
    /// </summary>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// The billing company for the project
    /// </summary>
    public string BillingCompany { get; set; } = null!;

    /// <summary>
    /// The agency associated with the project
    /// </summary>
    public string Agency { get; set; } = null!;

    /// <summary>
    /// The currency used for the project
    /// </summary>
    public string Currency { get; set; } = null!;

    /// <summary>
    /// The type of project
    /// </summary>
    public string ProjectType { get; set; } = null!;

    /// <summary>
    /// The tax type key for the project
    /// </summary>
    public string TaxTypeKey { get; set; } = null!;
} 