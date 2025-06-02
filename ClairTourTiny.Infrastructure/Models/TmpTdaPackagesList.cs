using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaPackagesList
{
    public int IdStockTypePackage { get; set; }

    public string? Caption { get; set; }

    public decimal? Price { get; set; }

    public int IdStockType { get; set; }

    public int? SortOrder { get; set; }

    public int Factor { get; set; }

    public string StockNumber { get; set; } = null!;

    public string StockDesc { get; set; } = null!;

    public string? FinessePartNo { get; set; }

    public string? Partno { get; set; }
}
