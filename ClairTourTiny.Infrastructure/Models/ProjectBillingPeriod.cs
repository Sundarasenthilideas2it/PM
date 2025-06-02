using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectBillingPeriod
{
    public string BidEntityno { get; set; } = null!;

    public short Periodno { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string PeriodTitle { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool ShowOnQuoteReport { get; set; }

    public int? DisplayOrder { get; set; }

    public virtual Glentity BidEntitynoNavigation { get; set; } = null!;

    public virtual ICollection<ProjectBillingPeriodItem1> ProjectBillingPeriodItem1s { get; set; } = new List<ProjectBillingPeriodItem1>();
}
