using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaPartNumbersView
{
    public string EjpartNo { get; set; } = null!;

    public string? Manufacturer { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string Description { get; set; } = null!;

    public decimal? Purchase { get; set; }

    public int? Inventory { get; set; }

    public string? Barcode { get; set; }
}
