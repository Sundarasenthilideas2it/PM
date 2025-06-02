using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpGoldfishCommodityMapping
{
    public string? SCategoryName { get; set; }

    public int ICategoryId { get; set; }

    public string ClairCommodity { get; set; } = null!;
}
