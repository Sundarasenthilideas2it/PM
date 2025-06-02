using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjPartsListDataFromAvgChildBarcodeQty
{
    public string Parentpartno { get; set; } = null!;

    public string ParentPartDesc { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string ChildPartDesc { get; set; } = null!;

    public int? EjavgFactor { get; set; }

    public double? FcurrentFactor { get; set; }
}
