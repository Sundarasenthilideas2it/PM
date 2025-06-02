using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class JobBudgetsPartsTransactionsTblTemp
{
    public string Src { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public DateTime Fromdate { get; set; }

    public int Qty { get; set; }

    public bool? Resolved { get; set; }
}
