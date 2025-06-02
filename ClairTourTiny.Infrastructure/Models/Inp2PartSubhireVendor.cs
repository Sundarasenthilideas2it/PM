using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Inp2PartSubhireVendor
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Partno { get; set; } = null!;

    public string Vendno { get; set; } = null!;

    public string Siteno { get; set; } = null!;

    public string? Notes { get; set; }

    public string Currency { get; set; } = null!;

    public decimal Rate { get; set; }

    public string RateType { get; set; } = null!;

    public decimal DeliveryRate { get; set; }

    public decimal ReturnRate { get; set; }
}
