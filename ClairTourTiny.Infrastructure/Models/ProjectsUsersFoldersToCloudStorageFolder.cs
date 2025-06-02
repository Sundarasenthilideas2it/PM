using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectsUsersFoldersToCloudStorageFolder
{
    public string Entityno { get; set; } = null!;

    public string UserFolderPath { get; set; } = null!;

    public string? DropboxFolderId { get; set; }

    public string? CloudFolderTemplate { get; set; }

    public string? AttachmentType { get; set; }

    public int IdLevel { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
