using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CloudFileStorageFolderRenameRequest
{
    public string OldUserFolderPath { get; set; } = null!;

    public string NewUserFolderPath { get; set; } = null!;

    public bool IsUpdated { get; set; }

    public string Entityno { get; set; } = null!;

    public DateTime UpdateTimeUtc { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
