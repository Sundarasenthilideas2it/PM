using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IntransDuplicates20171119
{
    public string Trantype { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public double Onhand { get; set; }

    public double Qty { get; set; }

    public DateOnly Trandate { get; set; }

    public string Orderno { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string? Ref5 { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string? Batchno { get; set; }

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Row { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public DateTime Enterdate { get; set; }

    public string Userid { get; set; } = null!;

    public int HeldInWarehouse { get; set; }

    public int HiwmoveQty { get; set; }

    public string ParentuniqueNo { get; set; } = null!;

    public DateTime EnterDateUtc { get; set; }
}
