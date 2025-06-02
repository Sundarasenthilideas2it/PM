using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BillingperioditemsEquipment
{
    public string BidEntityno { get; set; } = null!;

    public string? EquipmentEntityno { get; set; }

    public string Entitydesc { get; set; } = null!;

    public int? Qty { get; set; }

    public string? Partdesc { get; set; }

    public string Notes { get; set; } = null!;

    public int? Seqno { get; set; }

    public int Isbold { get; set; }

    public decimal EstUnitAmount { get; set; }

    public double? UnitBenchmark { get; set; }

    public double Markup { get; set; }

    public double? DaysBilled { get; set; }

    public int IdLanguage { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool ShowOnQuoteReport { get; set; }

    public string Partno { get; set; } = null!;
}
