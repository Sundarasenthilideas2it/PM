using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectBillingItemsRate
{
    public string BidEntityno { get; set; } = null!;

    public short Itemno { get; set; }

    public decimal? RateMultiplier { get; set; }
}
