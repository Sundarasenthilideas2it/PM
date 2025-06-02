using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpLdsystemsAutoSearchResult
{
    public string Id { get; set; } = null!;

    public string SearchSource { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public double Score { get; set; }

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
