using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EquipmentCheckedoutWDate
{
    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public int LineNo { get; set; }

    public DateTime Trandate { get; set; }

    public DateTime Todate { get; set; }

    public int EstQty { get; set; }
}
