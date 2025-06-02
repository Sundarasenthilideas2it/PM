using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectBillingItem
{
    public string BidEntityno { get; set; } = null!;

    public short Itemno { get; set; }

    public string? EquipmentEntityno { get; set; }

    public string? ExpenseEntityno { get; set; }

    public int? ExpenseSeqno { get; set; }

    public string? CrewEntityno { get; set; }

    public int? CrewEmplineNo { get; set; }

    public double NominalDailyRate { get; set; }

    public virtual Glentity BidEntitynoNavigation { get; set; } = null!;

    public virtual Glentity? EquipmentEntitynoNavigation { get; set; }

    public virtual Pjjobexpense? Pjjobexpense { get; set; }

    public virtual ICollection<ProjectBillingPeriodItem1> ProjectBillingPeriodItem1s { get; set; } = new List<ProjectBillingPeriodItem1>();
}
