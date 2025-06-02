using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpGoldfishMappingCommodity
{
    public string SiCategory { get; set; } = null!;

    public byte CategoryId { get; set; }

    public string ClairCommodity { get; set; } = null!;

    public string? Column4 { get; set; }

    public string? Column5 { get; set; }

    public string? Column6 { get; set; }

    public string? Commodity { get; set; }

    public int? ModelId { get; set; }
}
