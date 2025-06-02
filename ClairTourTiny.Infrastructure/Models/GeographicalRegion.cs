using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GeographicalRegion
{
    public string GeographicalRegion1 { get; set; } = null!;

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}
