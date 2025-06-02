using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SalesForecastGroup
{
    public string SalesForecastGroup1 { get; set; } = null!;

    public string SalesForecastGroupDesc { get; set; } = null!;

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
}
