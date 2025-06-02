using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsjobTypesMapping
{
    public decimal? Inviid { get; set; }

    public string? Sku { get; set; }

    public string? Description { get; set; }

    public string? Maingroup { get; set; }

    public string? Active { get; set; }

    public string? Inventorygroup { get; set; }

    public string? Discountgroup { get; set; }

    public string Jobtype { get; set; } = null!;
}
