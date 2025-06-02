using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CycleCountUnitCostCategory
{
    public string Category { get; set; } = null!;

    public double UnitCostLowerBound { get; set; }

    public double? UnitCostUpperBound { get; set; }
}
