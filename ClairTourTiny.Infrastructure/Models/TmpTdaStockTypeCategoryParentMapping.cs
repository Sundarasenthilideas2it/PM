using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaStockTypeCategoryParentMapping
{
    public int IdStockTypeCategoryParent { get; set; }

    public string Caption { get; set; } = null!;

    public int SortPosition { get; set; }

    public int? IdRmbranch { get; set; }

    public string? Rmcaption { get; set; }

    public string? CaptionLng2 { get; set; }

    public string? CaptionLng3 { get; set; }

    public string? CaptionLng4 { get; set; }

    public string? CaptionLng5 { get; set; }

    public string? CaptionLng6 { get; set; }

    public string? Commodity { get; set; }
}
