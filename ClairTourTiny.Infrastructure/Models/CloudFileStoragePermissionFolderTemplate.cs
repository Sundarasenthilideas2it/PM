using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CloudFileStoragePermissionFolderTemplate
{
    public string CloudFolderTemplate { get; set; } = null!;

    public string? DropboxFilePathSuffix { get; set; }

    public virtual ICollection<CloudFileStorageShareRequest> CloudFileStorageShareRequests { get; set; } = new List<CloudFileStorageShareRequest>();

    public virtual ICollection<AttachmentType> AttachmentTypes { get; set; } = new List<AttachmentType>();

    public virtual ICollection<CloudFileStorageGroup> IdLevels { get; set; } = new List<CloudFileStorageGroup>();
}
