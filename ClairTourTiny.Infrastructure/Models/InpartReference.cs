using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartReference
{
    public string Partno { get; set; } = null!;

    public string Parentpartno { get; set; } = null!;

    public double Factor { get; set; }

    public short IdReferenceType { get; set; }

    public int? IdPartnoReference { get; set; }

    public virtual InpartReferenceType IdReferenceTypeNavigation { get; set; } = null!;

    public virtual Inpart ParentpartnoNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
