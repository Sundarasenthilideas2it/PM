using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GlobalOpsMonitoredDocument
{
    public string FileName { get; set; } = null!;

    public string Folder { get; set; } = null!;

    public long Size { get; set; }

    public DateTime? DateModified { get; set; }

    public int FolderId { get; set; }

    public virtual GlobalOpsMonitoredFolder FolderNavigation { get; set; } = null!;
}
