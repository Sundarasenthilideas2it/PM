using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjDailyPriceOverride
{
    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public double? Dailyprice { get; set; }
}
