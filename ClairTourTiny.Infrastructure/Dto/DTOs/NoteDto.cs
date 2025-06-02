using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for note information
/// </summary>
public class NoteDto
{
    /// <summary>
    /// The unique identifier of the note
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this note is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The type of note
    /// </summary>
    public string NoteType { get; set; } = null!;

    /// <summary>
    /// The content of the note
    /// </summary>
    public string Content { get; set; } = null!;

    /// <summary>
    /// The user who created the note
    /// </summary>
    public string CreatedBy { get; set; } = null!;

    /// <summary>
    /// The date the note was created
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Whether the note is private
    /// </summary>
    public bool IsPrivate { get; set; }

    /// <summary>
    /// The category of the note
    /// </summary>
    public string Category { get; set; } = null!;

    /// <summary>
    /// The ID of the related entity
    /// </summary>
    public string? RelatedId { get; set; }

    /// <summary>
    /// The type of related entity
    /// </summary>
    public string? RelatedType { get; set; }

    /// <summary>
    /// The date the note was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified the note
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 