using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EquipmentCheckoutSummary
{
    public string Entityno { get; set; } = null!;

    public DateTime Trandate { get; set; }

    public DateTime Todate { get; set; }

    public int? ItemsReq { get; set; }

    public int? ItemsOut { get; set; }

    public long? CBig { get; set; }
}
