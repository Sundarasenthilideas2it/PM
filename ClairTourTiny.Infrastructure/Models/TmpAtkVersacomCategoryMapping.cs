using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpAtkVersacomCategoryMapping
{
    public decimal MappingId { get; set; }

    public string Atkvcategory { get; set; } = null!;

    public string Commodity { get; set; } = null!;
}
