using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Billingperioditem
{
    public string BidEntityno { get; set; } = null!;

    public short Itemno { get; set; }

    public string PeriodTitle { get; set; } = null!;

    public DateTime PeriodStartdate { get; set; }

    public DateTime PeriodEnddate { get; set; }

    public int? PeriodDisplayOrder { get; set; }

    public bool ShowOnQuoteReport { get; set; }

    public string? ItemDesc { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int? Itemdays { get; set; }

    public double? Billingdays { get; set; }

    public double? UnitBenchmark { get; set; }

    public double AdjustedWeekly { get; set; }

    public double? Rate { get; set; }

    public double? PeriodTotal { get; set; }

    public short Periodno { get; set; }

    public string? ExpenseEntityno { get; set; }

    public int? ExpenseSeqno { get; set; }

    public string? CrewEntityno { get; set; }

    public string? CrewJobtype { get; set; }

    public int? CrewSeqno { get; set; }

    public string? EquipmentEntityno { get; set; }
}
