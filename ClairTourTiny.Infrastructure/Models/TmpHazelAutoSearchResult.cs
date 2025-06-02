using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpHazelAutoSearchResult
{
    public string ItemId { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public double Score { get; set; }
}
