using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InventoryChildPartsConsolidated
{
    public string Partno { get; set; } = null!;

    public string ParentuniqueNo { get; set; } = null!;

    public long? Checkoutqty { get; set; }
}
