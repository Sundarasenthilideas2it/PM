using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanTruckRackUpdate
{
    public string? Partno { get; set; }

    public string? Truck { get; set; }

    public double? RackUnits { get; set; }

    public string? RackBays { get; set; }
}
