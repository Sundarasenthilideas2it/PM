using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaEquipmentCheckOut
{
    public int IdStockType2JobGroup { get; set; }

    public int Factor { get; set; }

    public int? Loaded { get; set; }

    public int? Back { get; set; }

    public int? CheckedOut { get; set; }

    public string? EntityNo { get; set; }

    public string? Partno { get; set; }
}
