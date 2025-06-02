using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartGroupsBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string PartGroupOld { get; set; } = null!;

    public string PartGroupNew { get; set; } = null!;

    public Guid FileStorageGuid { get; set; }
}
