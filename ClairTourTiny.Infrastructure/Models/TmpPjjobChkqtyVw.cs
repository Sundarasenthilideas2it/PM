using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPjjobChkqtyVw
{
    public string Partno { get; set; } = null!;

    public string Partrev { get; set; } = null!;

    public string Partentityno { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public int? TotLineNo { get; set; }
}
