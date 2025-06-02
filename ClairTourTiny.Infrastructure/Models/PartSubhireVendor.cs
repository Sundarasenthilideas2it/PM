using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartSubhireVendor
{
    public string Partno { get; set; } = null!;

    public string Vendno { get; set; } = null!;

    public string Siteno { get; set; } = null!;

    public string? Notes { get; set; }

    public string Currency { get; set; } = null!;

    public decimal Rate { get; set; }

    public string RateType { get; set; } = null!;

    public decimal DeliveryRate { get; set; }

    public decimal ReturnRate { get; set; }

    public virtual Currency CurrencyNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
