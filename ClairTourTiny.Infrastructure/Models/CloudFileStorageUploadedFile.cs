using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CloudFileStorageUploadedFile
{
    public string FileName { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public bool IsUploaded { get; set; }

    public string? DropboxFileId { get; set; }

    public DateTime UploadTime { get; set; }

    public string? AttachmentType { get; set; }

    public string AttachmentCategory { get; set; } = null!;

    public string UserFolderPath { get; set; } = null!;

    public string? Userid { get; set; }

    public bool FileMissingAtUpload { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
