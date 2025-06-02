using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpsDevice
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Partno { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Row { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public string OrigUniqueNo { get; set; } = null!;

    public string OrigDept { get; set; } = null!;

    public string OrigBld { get; set; } = null!;

    public string OrigRow { get; set; } = null!;

    public string OrigSerialNo { get; set; } = null!;

    public string? Ref4 { get; set; }

    public string? Ref5 { get; set; }

    public int QtyToDelete { get; set; }

    public int OrigOnhand { get; set; }

    public int Onhand { get; set; }

    public string? Area { get; set; }

    public bool ShouldReturnLinkedChildPartsToWorkingInventory { get; set; }

    public string ParentuniqueNo { get; set; } = null!;
}
