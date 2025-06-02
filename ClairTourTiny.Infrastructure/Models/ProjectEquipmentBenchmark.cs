using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectEquipmentBenchmark
{
    public string Entityno { get; set; } = null!;

    public double? UnitBenchmark { get; set; }

    public double? UnitOverride { get; set; }

    public long? CBig { get; set; }
}
