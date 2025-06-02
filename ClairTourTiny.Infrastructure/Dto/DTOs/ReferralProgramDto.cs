using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for referral program information
/// </summary>
public class ReferralProgramDto
{
    /// <summary>
    /// The unique identifier of the referral program
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this referral program is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The program code
    /// </summary>
    public string ProgramCode { get; set; } = null!;

    /// <summary>
    /// The description of the referral program
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Whether this referral program is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The commission rate for referrals
    /// </summary>
    public decimal? CommissionRate { get; set; }

    /// <summary>
    /// The minimum referral amount
    /// </summary>
    public decimal? MinimumReferralAmount { get; set; }

    /// <summary>
    /// The maximum referral amount
    /// </summary>
    public decimal? MaximumReferralAmount { get; set; }

    /// <summary>
    /// The default currency for the program
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The default tax code for the program
    /// </summary>
    public string? DefaultTaxCode { get; set; }

    /// <summary>
    /// The sort order for this program
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the referral program
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this program was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this program
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 