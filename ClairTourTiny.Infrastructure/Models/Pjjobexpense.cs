using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pjjobexpense
{
    public string Entityno { get; set; } = null!;

    public int Seqno { get; set; }

    public string Expcd { get; set; } = null!;

    public string Expdesc { get; set; } = null!;

    public string PeriodType { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public double ItemCost { get; set; }

    public int ItemQty { get; set; }

    public double Cost { get; set; }

    public string Category { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;

    public virtual Apexpcode ExpcdNavigation { get; set; } = null!;

    public virtual ExpensePeriodType PeriodTypeNavigation { get; set; } = null!;

    public virtual ICollection<ProjectBillingItem> ProjectBillingItems { get; set; } = new List<ProjectBillingItem>();
}
