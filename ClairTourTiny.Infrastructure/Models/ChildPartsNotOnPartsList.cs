using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ChildPartsNotOnPartsList
{
    public string ChildPartNo { get; set; } = null!;

    public string ChildPartDesc { get; set; } = null!;

    public int? AverageChildrenPer { get; set; }

    public string ParentPartNo { get; set; } = null!;

    public string ParentPartDesc { get; set; } = null!;

    public string Bld { get; set; } = null!;
}
