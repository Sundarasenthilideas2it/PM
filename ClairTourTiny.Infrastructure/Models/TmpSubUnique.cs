using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSubUnique
{
    public string Partno { get; set; } = null!;

    public string Partrev { get; set; } = null!;

    public string Partentityno { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public double? TotOnhand { get; set; }
}
