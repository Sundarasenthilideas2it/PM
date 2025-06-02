using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CloudFileStorageFileRenameRequest
{
    public string OldFileName { get; set; } = null!;

    public string NewFileName { get; set; } = null!;

    public bool IsUpdated { get; set; }

    public string Entityno { get; set; } = null!;

    public DateTime UpdateTimeUtc { get; set; }

    public string UserFolderPath { get; set; } = null!;
}
