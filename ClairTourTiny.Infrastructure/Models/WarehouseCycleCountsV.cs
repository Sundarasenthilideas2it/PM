using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class WarehouseCycleCountsV
{
    public string Warehouse { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public DateTime Lastcount { get; set; }

    public string? Username { get; set; }

    public long? R { get; set; }
}
