using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdssubcategoryMapping
{
    public string Invsubcategoryid { get; set; } = null!;

    public string Invsubcategorydesc { get; set; } = null!;

    public string? Commodity { get; set; }

    public string? SecondaryCategoryCode { get; set; }

    public string? MergeSecondaryCategoryCode { get; set; }

    public string? Manufacturer { get; set; }

    public string? PartGroup { get; set; }
}
