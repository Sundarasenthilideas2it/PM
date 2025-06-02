using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjinventoryAndPurchasePrice
{
    public string? JpjarticleNo { get; set; }

    public string? SerialNo { get; set; }

    public decimal PurchasePriceAus { get; set; }
}
