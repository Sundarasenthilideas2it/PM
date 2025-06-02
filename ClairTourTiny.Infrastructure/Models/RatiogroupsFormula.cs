using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RatiogroupsFormula
{
    public int GroupId { get; set; }

    public string Partno { get; set; } = null!;

    public decimal Multiplier { get; set; }

    public string Category { get; set; } = null!;

    public virtual Ratiogroup Group { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
