using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for proposal type information
/// </summary>
public class ProposalTypeDto
{
    /// <summary>
    /// The unique identifier of the proposal type
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this proposal type is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The proposal type code
    /// </summary>
    public string ProposalTypeCode { get; set; } = null!;

    /// <summary>
    /// The description of the proposal type
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this proposal type is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The default markup percentage for this proposal type
    /// </summary>
    public decimal? DefaultMarkupPercentage { get; set; }

    /// <summary>
    /// The default currency for this proposal type
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The default payment terms for this proposal type
    /// </summary>
    public string? DefaultPaymentTerms { get; set; }

    /// <summary>
    /// The default validity period in days
    /// </summary>
    public int? DefaultValidityPeriod { get; set; }

    /// <summary>
    /// Any notes about the proposal type
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this proposal type was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this proposal type
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 