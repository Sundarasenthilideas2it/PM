using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartLocationHistory
{
    public string Partno { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public int Onhand { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Parentpartno { get; set; } = null!;

    public virtual Day? EndDateNavigation { get; set; }

    public virtual Inpart PartnoNavigation { get; set; } = null!;

    public virtual Day StartDateNavigation { get; set; } = null!;
}
