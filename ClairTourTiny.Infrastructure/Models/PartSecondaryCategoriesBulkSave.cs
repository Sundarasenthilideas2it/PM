using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartSecondaryCategoriesBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string SecondaryCategoryCodeOld { get; set; } = null!;

    public string SecondaryCategoryCodeNew { get; set; } = null!;

    public string SecondaryCategoryDesc { get; set; } = null!;

    public string? PrimaryCategoryCode { get; set; }

    public string? Commodity { get; set; }

    public Guid? FileStorageGuid { get; set; }
}
