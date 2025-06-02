using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectBillingPeriodActiveItem
{
    public string BidEntityno { get; set; } = null!;

    public short Periodno { get; set; }

    public byte Itemno { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? BillingDays { get; set; }

    public bool IsActive { get; set; }

    public double ActualDailyRate { get; set; }

    public double? PeriodTotal { get; set; }

    public double? ActualBillingDays { get; set; }
}
