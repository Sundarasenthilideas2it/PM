using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pjinvratetype
{
    public string Ratetype { get; set; } = null!;

    public string Ratedesc { get; set; } = null!;

    public int Perioddays { get; set; }

    public string ShortRateDesc { get; set; } = null!;

    public virtual ICollection<Rfi> Rfis { get; set; } = new List<Rfi>();
}
