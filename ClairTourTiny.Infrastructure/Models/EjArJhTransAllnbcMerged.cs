using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EjArJhTransAllnbcMerged
{
    public string TranType { get; set; } = null!;

    public string? Partno { get; set; }

    public string Onhand { get; set; } = null!;

    public int? Qty { get; set; }

    public DateTime? Trandate { get; set; }

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public int Groupno { get; set; }

    public string? EjEntitydesc { get; set; }

    public string? Dept { get; set; }

    public string? Bld { get; set; }

    public string SerialNo { get; set; } = null!;

    public DateTime? Enterdate { get; set; }

    public DateTime? Sortdate { get; set; }

    public string? Userid { get; set; }
}
