using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BillingperioditemsGroupsSummary
{
    public string BidEntityno { get; set; } = null!;

    public string? Grouptype { get; set; }

    public int Sortorder { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public double? PeriodTotal { get; set; }
}
