using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SoundTrackerIocardOrderedGearImport
{
    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public int Seqno { get; set; }

    public int EstQty { get; set; }

    public DateTime Trandate { get; set; }

    public DateTime Todate { get; set; }
}
