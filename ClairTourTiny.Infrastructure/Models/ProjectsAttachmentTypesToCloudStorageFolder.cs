using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectsAttachmentTypesToCloudStorageFolder
{
    public string AttachmentType { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string? DropBoxId { get; set; }

    public string? SharedFolderId { get; set; }

    public virtual AttachmentType AttachmentTypeNavigation { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
