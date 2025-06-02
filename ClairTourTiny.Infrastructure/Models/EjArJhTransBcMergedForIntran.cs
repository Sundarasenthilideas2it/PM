using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EjArJhTransBcMergedForIntran
{
    public string TranType { get; set; } = null!;

    public string? Partno { get; set; }

    public int Onhand { get; set; }

    public int Qty { get; set; }

    public DateTime? Trandate { get; set; }

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string? UniqueNo { get; set; }

    public string Batchno { get; set; } = null!;

    public int Groupno { get; set; }

    public string EjEntitydesc { get; set; } = null!;

    public string? Dept { get; set; }

    public string? Bld { get; set; }

    public string? SerialNo { get; set; }

    public DateTime? Enterdate { get; set; }

    public DateTime? Sortdate { get; set; }

    public string? Userid { get; set; }

    public int? Idlogaction { get; set; }
}
