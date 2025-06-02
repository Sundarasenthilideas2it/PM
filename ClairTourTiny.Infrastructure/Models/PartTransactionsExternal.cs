using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartTransactionsExternal
{
    public string Partno { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public DateOnly Date { get; set; }

    public int Qty { get; set; }

    public string SourceType { get; set; } = null!;

    public string SourceKey { get; set; } = null!;

    public virtual Warehouse BldNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
