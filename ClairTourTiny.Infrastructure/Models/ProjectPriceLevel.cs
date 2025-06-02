using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectPriceLevel
{
    public double PriceLevelValue { get; set; }

    public bool IsDefault { get; set; }

    public bool IsVisible { get; set; }
}
