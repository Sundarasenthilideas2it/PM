using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TouringRevenueGroup
{
    public string TouringRevenueGroup1 { get; set; } = null!;

    public string TouringRevenueGroupDesc { get; set; } = null!;

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();
}
