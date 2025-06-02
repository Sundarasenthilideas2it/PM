using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PjjobbudexpHistory
{
    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public double EstQty { get; set; }

    public DateTime Trandate { get; set; }

    public DateTime Todate { get; set; }

    public int Seqno { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
