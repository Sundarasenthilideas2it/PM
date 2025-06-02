using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaPartsList1
{
    public int IdStockType { get; set; }

    public string ChildNumber { get; set; } = null!;

    public string ChildDesc { get; set; } = null!;

    public int IdStockTypeParent { get; set; }

    public string ParentNumber { get; set; } = null!;

    public string PartDesc { get; set; } = null!;

    public decimal Factor { get; set; }

    public string? FinesseChild { get; set; }

    public string? FinesseParent { get; set; }

    public int? SortOrder { get; set; }

    public bool? IsOptional { get; set; }

    public string CaptionEn { get; set; } = null!;
}
