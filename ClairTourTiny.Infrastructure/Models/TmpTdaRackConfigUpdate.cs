using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaRackConfigUpdate
{
    public string? Partno { get; set; }

    public int? RackUnits { get; set; }

    public int? RackBays { get; set; }
}
