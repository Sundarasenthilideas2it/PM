using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class OrderedPartsListParentAndChild
{
    public string Entityno { get; set; } = null!;

    public string? Parentpartno { get; set; }

    public string Partno { get; set; } = null!;

    public int EstQty { get; set; }

    public double Factor { get; set; }
}
