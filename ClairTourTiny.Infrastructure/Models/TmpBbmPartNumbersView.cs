using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBbmPartNumbersView
{
    public string? Ejpartno { get; set; }

    public string? Caption { get; set; }

    public double? Inventory { get; set; }

    public decimal? PurchasePrice { get; set; }
}
