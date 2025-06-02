using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectBillingPeriodItem1
{
    public string BidEntityno { get; set; } = null!;

    public short Periodno { get; set; }

    public short Itemno { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? BillingDays { get; set; }

    public bool IsActive { get; set; }

    public double ActualDailyRate { get; set; }

    public double? PeriodTotal { get; set; }

    public virtual ProjectBillingItem ProjectBillingItem { get; set; } = null!;

    public virtual ProjectBillingPeriod ProjectBillingPeriod { get; set; } = null!;
}
