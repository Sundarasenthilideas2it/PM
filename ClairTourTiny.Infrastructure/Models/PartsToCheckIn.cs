using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartsToCheckIn
{
    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public DateTime Todate { get; set; }

    public int LineNo { get; set; }

    public int EstQty { get; set; }

    public string? MfgDesc { get; set; }
}
