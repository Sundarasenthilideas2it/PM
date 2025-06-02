using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Dropboxerror
{
    public string FileName { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public bool IsUploaded { get; set; }

    public string? DropboxFileId { get; set; }

    public string? AttachmentType { get; set; }

    public string AttachmentCategory { get; set; } = null!;

    public string UserFolderPath { get; set; } = null!;

    public Guid Guid { get; set; }

    public string Entitydesc { get; set; } = null!;

    public string? DropboxFolderId { get; set; }

    public string? CloudFolderTemplate { get; set; }

    public int IdLevel { get; set; }

    public string? DropboxFilePathSuffix { get; set; }
}
