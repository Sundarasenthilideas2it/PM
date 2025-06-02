using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CloudFileStorageUploadedFilesA
{
    public string? FileName { get; set; }

    public string? Entityno { get; set; }

    public bool? IsUploaded { get; set; }

    public string? DropboxFileId { get; set; }

    public DateTime? UploadTime { get; set; }

    public string? AttachmentType { get; set; }

    public string? AttachmentCategory { get; set; }

    public string? UserFolderPath { get; set; }

    public string? Userid { get; set; }

    public bool? FileMissingAtUpload { get; set; }

    public DateTime? AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
