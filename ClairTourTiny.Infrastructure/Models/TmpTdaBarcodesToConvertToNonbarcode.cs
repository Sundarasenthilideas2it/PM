using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaBarcodesToConvertToNonbarcode
{
    public string Category { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public int? Onhand { get; set; }

    public string? UniqueNo { get; set; }

    public string? Batchno { get; set; }

    public string? Bld { get; set; }
}
