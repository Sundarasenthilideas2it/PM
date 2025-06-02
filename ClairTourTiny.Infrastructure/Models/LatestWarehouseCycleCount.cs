using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class LatestWarehouseCycleCount
{
    public string Warehouse { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public DateTime? Lastcount { get; set; }
}
