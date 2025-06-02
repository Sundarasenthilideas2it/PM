using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpAtkCategoryMapping
{
    public decimal MappingId { get; set; }

    public string Atkcategory { get; set; } = null!;

    public string Commodity { get; set; } = null!;
}
