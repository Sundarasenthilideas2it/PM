using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartsMergeHistory
{
    public string Partno { get; set; } = null!;

    public bool IsPartMergedInto { get; set; }

    public DateTime DateMergedUtc { get; set; }
}
