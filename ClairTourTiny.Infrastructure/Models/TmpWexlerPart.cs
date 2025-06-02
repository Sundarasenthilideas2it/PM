using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpWexlerPart
{
    public string? PartNo { get; set; }

    public string? PartDescriptionOperational { get; set; }

    public string? PartDescriptionSales { get; set; }

    public string? Category { get; set; }

    public double? CurrentValue { get; set; }
}
