using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdssubCategoryManufacturerPartGroupMapping
{
    public string? EdsSubCategory { get; set; }

    public string? ClairPrimaryCategory { get; set; }

    public string? ClairSubCategory { get; set; }

    public string? Manufacturer { get; set; }

    public string? PartGroup { get; set; }

    public string? Notes { get; set; }
}
