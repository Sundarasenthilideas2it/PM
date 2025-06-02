using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartProperty1
{
    public string Partno { get; set; } = null!;

    public int IdPropertyType { get; set; }

    public int Seqno { get; set; }

    public string Value { get; set; } = null!;

    public string? Note { get; set; }

    public virtual PartPropertyType IdPropertyTypeNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
