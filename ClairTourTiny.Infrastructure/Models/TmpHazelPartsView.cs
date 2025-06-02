using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpHazelPartsView
{
    public string ItemId { get; set; } = null!;

    public string? Caption { get; set; }

    public string? Manufacturer { get; set; }

    public string? Inventory { get; set; }

    public double? PurchasePrice { get; set; }

    public double? TotalGbp { get; set; }
}
