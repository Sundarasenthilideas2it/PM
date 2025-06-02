using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBillingDaysBenchmarkUpdate
{
    public string Company { get; set; } = null!;

    public int Daysused { get; set; }

    public double Daysbilled { get; set; }

    public string Proptype { get; set; } = null!;
}
