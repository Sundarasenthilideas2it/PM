using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpsDisassemblyPart
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string ParentPartNo { get; set; } = null!;

    public string ChildPartNo { get; set; } = null!;

    public string? OldChildPartNo { get; set; }

    public int Quantity { get; set; }

    public decimal? PricePercentage { get; set; }
}
