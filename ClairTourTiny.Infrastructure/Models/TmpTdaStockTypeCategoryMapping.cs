using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaStockTypeCategoryMapping
{
    public int IdStockTypeCategory { get; set; }

    public int? NewIdStockTypeCategory { get; set; }

    public string Caption { get; set; } = null!;

    public string? Commodity { get; set; }
}
