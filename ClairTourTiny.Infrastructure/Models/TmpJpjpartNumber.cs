using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjpartNumber
{
    public string? FinessePartNo { get; set; }

    public string? JpjarticleNo { get; set; }

    public string? PartDesc { get; set; }

    public decimal? AvgPurchasePriceAus { get; set; }

    public int? Qty { get; set; }
}
