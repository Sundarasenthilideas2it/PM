using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pm2GetProjectBillingPeriodItems2V
{
    public string BidEntityno { get; set; } = null!;

    public short Periodno { get; set; }

    public short Itemno { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool Status { get; set; }

    public double? BillingDays { get; set; }

    public double Rate { get; set; }

    public double NominalDailyRate { get; set; }

    public double ActualDailyRate { get; set; }

    public string? ExpenseEntityno { get; set; }

    public string? Category { get; set; }

    public int? ExpenseSeqno { get; set; }

    public string? CrewEntityno { get; set; }

    public string? EquipmentEntityno { get; set; }

    public int? CrewSeqno { get; set; }
}
