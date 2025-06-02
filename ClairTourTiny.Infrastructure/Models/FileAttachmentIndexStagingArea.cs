using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FileAttachmentIndexStagingArea
{
    public string? FileName { get; set; }

    public DateTime? CreationTimeUtc { get; set; }

    public Guid? Guid { get; set; }

    public string? SubFolderPath { get; set; }

    public string? CreatedBy { get; set; }

    public bool IsCreate { get; set; }

    public bool IsDelete { get; set; }
}
