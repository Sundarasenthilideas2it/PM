using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DivisionPayrollTypeBurdenRate
{
    public string Division { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public DateOnly ValidFrom { get; set; }

    public DateOnly? ValidThrough { get; set; }

    public decimal BurdenRatePercent { get; set; }

    public decimal? BurdenRate { get; set; }

    public virtual Pedivision DivisionNavigation { get; set; } = null!;

    public virtual PeemployeeRef4 Ref4Navigation { get; set; } = null!;
}
