using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MergedJobBudgetsPartsTransactionsTbl
{
    public string Bld { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public DateTime Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public int Qty { get; set; }

    public int CumulativeQty { get; set; }

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
