using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CloudFileStorageShareRequest
{
    public string Email { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string CloudFolderTemplate { get; set; } = null!;

    public string UserFolderPath { get; set; } = null!;

    public bool IsExecuted { get; set; }

    public bool IsAddFolderMember { get; set; }

    public bool IsRemoveFolderMember { get; set; }

    public DateTime AddFolderMemberTime { get; set; }

    public string AttachmentCategory { get; set; } = null!;

    public DateTime? RemoveFolderMemberTime { get; set; }

    public string? Note { get; set; }

    public bool IsEgnyteShare { get; set; }

    public virtual CloudFileStoragePermissionFolderTemplate CloudFolderTemplateNavigation { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
