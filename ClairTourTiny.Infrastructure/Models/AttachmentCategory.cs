using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AttachmentCategory
{
    public string AttachmentCategory1 { get; set; } = null!;

    public bool AttachmentsCanBeInKnowledgeBase { get; set; }

    public string? DefaultRootFolderPath { get; set; }

    public virtual ICollection<AttachmentType> AttachmentTypes { get; set; } = new List<AttachmentType>();
}
