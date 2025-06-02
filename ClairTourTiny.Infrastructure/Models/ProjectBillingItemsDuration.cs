using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectBillingItemsDuration
{
    public string BidEntityno { get; set; } = null!;

    public short Itemno { get; set; }

    public int? Duration { get; set; }

    public int IsEquipment { get; set; }

    public long? CBig { get; set; }
}
