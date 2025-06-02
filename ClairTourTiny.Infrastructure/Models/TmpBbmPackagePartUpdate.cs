using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBbmPackagePartUpdate
{
    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public string? Commmodity { get; set; }

    public string? Package { get; set; }

    public string? Package1 { get; set; }

    public double? Rackheight { get; set; }

    public double? Rackcount { get; set; }

    public string? Unused { get; set; }

    public double? LengthUom { get; set; }

    public double? DepthUom { get; set; }

    public double? WidthUom { get; set; }
}
