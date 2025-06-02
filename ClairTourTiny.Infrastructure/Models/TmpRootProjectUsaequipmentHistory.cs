using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpRootProjectUsaequipmentHistory
{
    public string? Rootproject { get; set; }

    public string Partno { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public int? Onhand { get; set; }
}
