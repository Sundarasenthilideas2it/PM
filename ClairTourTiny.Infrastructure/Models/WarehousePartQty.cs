using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class WarehousePartQty
{
    public string Partno { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public int? TotalQty { get; set; }

    public int? InstockQty { get; set; }

    public int? RepairQty { get; set; }

    public long? CBig { get; set; }
}
