using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CloudFileStorageUploadedPartFile
{
    public string FileName { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public bool IsUploaded { get; set; }

    public string? DropboxFileId { get; set; }

    public DateTime UploadTime { get; set; }

    public string? AttachmentType { get; set; }

    public string UserFolderPath { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
