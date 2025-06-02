using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GlobalOpsMonitoredFolder
{
    public string Path { get; set; } = null!;

    public bool Recurse { get; set; }

    public int FolderId { get; set; }

    public virtual ICollection<GlobalOpsMonitoredDocument> GlobalOpsMonitoredDocuments { get; set; } = new List<GlobalOpsMonitoredDocument>();
}
