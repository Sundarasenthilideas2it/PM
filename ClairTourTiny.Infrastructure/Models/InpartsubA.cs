using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartsubA
{
    public string? Partno { get; set; }

    public string? UniqueNo { get; set; }

    public string? Batchno { get; set; }

    public string? Dept { get; set; }

    public string? Bld { get; set; }

    public string? Area { get; set; }

    public string? Row { get; set; }

    public string? SerialNo { get; set; }

    public int? Onhand { get; set; }

    public DateTime? Receipt { get; set; }

    public string? Parentpartno { get; set; }

    public string? ParentuniqueNo { get; set; }

    public string? ParentserialNo { get; set; }

    public int? HeldInWarehouse { get; set; }

    public DateTime AdateTime { get; set; }

    public string AuserId { get; set; } = null!;

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }

    public string? OldUniqueNo { get; set; }

    public string? OldBatchno { get; set; }

    public string? OldBld { get; set; }

    public string? OldArea { get; set; }

    public string? OldSerialNo { get; set; }

    public string? OldParentunqieNo { get; set; }

    public string? OldPartno { get; set; }
}
