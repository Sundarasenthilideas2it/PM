using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FileStoragePath
{
    public string FileStoragePath1 { get; set; } = null!;

    public Guid FileStorageGuid { get; set; }

    public DateTime? LatestCreatedFileTimeUtc { get; set; }

    public DateTime? CreationTimeUtc { get; set; }

    public virtual ICollection<EgnyteShareRequest> EgnyteShareRequests { get; set; } = new List<EgnyteShareRequest>();
}
