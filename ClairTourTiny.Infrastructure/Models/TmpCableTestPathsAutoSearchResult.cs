using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpCableTestPathsAutoSearchResult
{
    public string Path { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public double Score { get; set; }

    public int Airank { get; set; }

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
