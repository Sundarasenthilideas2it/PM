using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartsListWeightsValue
{
    public string Partno { get; set; } = null!;

    public double Partslistweight { get; set; }

    public double? Partslistcubic { get; set; }

    public double Partslistvalue { get; set; }
}
