using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pjjobrevenue
{
    public string Entityno { get; set; } = null!;

    public int Seqno { get; set; }

    public string Notes { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public double Amount { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
