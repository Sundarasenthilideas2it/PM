using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartGroupsPart
{
    public string PartGroup { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public int? GroupId { get; set; }

    public virtual PartGroup PartGroupNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
