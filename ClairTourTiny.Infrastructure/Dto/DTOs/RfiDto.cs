using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for RFI (Request for Information) data
/// </summary>
public class RfiDto
{
    /// <summary>
    /// The unique identifier of the RFI
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this RFI is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The RFI number
    /// </summary>
    public string RfiNumber { get; set; } = null!;

    /// <summary>
    /// The subject of the RFI
    /// </summary>
    public string Subject { get; set; } = null!;

    /// <summary>
    /// The description of the RFI
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// The status of the RFI
    /// </summary>
    public string Status { get; set; } = null!;

    /// <summary>
    /// The date the RFI was submitted
    /// </summary>
    public DateTime SubmissionDate { get; set; }

    /// <summary>
    /// The date the RFI is due
    /// </summary>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// The date the RFI was responded to
    /// </summary>
    public DateTime? ResponseDate { get; set; }

    /// <summary>
    /// The response to the RFI
    /// </summary>
    public string? Response { get; set; }

    /// <summary>
    /// The user who submitted the RFI
    /// </summary>
    public string SubmittedBy { get; set; } = null!;

    /// <summary>
    /// The user who responded to the RFI
    /// </summary>
    public string? RespondedBy { get; set; }

    /// <summary>
    /// The priority of the RFI
    /// </summary>
    public string Priority { get; set; } = null!;

    /// <summary>
    /// Any attachments for the RFI
    /// </summary>
    public string? Attachments { get; set; }

    /// <summary>
    /// The date this RFI was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this RFI
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 