using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PurchaseOrder
{
    public int IdPurchaseOrder { get; set; }

    public int Ponumber { get; set; }

    public string? Podescription { get; set; }

    public string Company { get; set; } = null!;

    public int IsCrew { get; set; }

    public int IsSubhire { get; set; }

    public string? Vendno { get; set; }

    public string? VendsiteNo { get; set; }
}
