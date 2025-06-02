using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartCommoditySubcategory
{
    public string Commodity { get; set; } = null!;

    public string? Subcategory { get; set; }
}
