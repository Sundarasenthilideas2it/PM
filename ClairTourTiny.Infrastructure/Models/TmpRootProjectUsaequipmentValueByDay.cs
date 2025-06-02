using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpRootProjectUsaequipmentValueByDay
{
    public string? Rootproject { get; set; }

    public DateTime? Dt { get; set; }

    public double? Value { get; set; }

    public int Pct { get; set; }
}
