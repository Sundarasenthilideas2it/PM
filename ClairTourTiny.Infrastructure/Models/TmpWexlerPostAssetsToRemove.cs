using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpWexlerPostAssetsToRemove
{
    public string? Description { get; set; }

    public string? Partno { get; set; }

    public double? ClairOlv { get; set; }

    public int? OriginalQty { get; set; }

    public int? RemoveQty { get; set; }
}
