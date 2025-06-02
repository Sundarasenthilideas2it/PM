using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DryHireBillingDaysRate
{
    public string Company { get; set; } = null!;

    public int Daysused { get; set; }

    public double Daysbilled { get; set; }

    public virtual Company CompanyNavigation { get; set; } = null!;
}
