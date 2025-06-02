using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BillingperioditemsSummary
{
    public string BidEntityno { get; set; } = null!;

    public string? ItemDesc { get; set; }

    public int? TotalDays { get; set; }

    public double AdjustedWeekly { get; set; }

    public double? PeriodTotal { get; set; }

    public string? ExpenseEntityno { get; set; }

    public int? ExpenseSeqno { get; set; }

    public string? CrewEntityno { get; set; }

    public int? CrewEmplineNo { get; set; }

    public string? EquipmentEntityno { get; set; }

    public bool? IsFixedExpense { get; set; }
}
