using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectQuotedVsBenchmark
{
    public string? Project { get; set; }

    public string? Bidroot { get; set; }

    public string? Currency { get; set; }

    public double EquipmentBenchmarkAmt { get; set; }

    public double EquipmentQuotedAmt { get; set; }

    public double? BidVariance { get; set; }

    public double? CrewQuotedAmt { get; set; }

    public double? ExpensesQuotedAmt { get; set; }

    public DateTime? Mindate { get; set; }

    public DateTime? Maxdate { get; set; }
}
