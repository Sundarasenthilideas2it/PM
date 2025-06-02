using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartPriceUpdateBulkSave
{
    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public decimal? UnitCost { get; set; }

    public double? NewSellingPrice { get; set; }

    public double? RentalValueUsd { get; set; }
}
