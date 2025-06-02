using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AgedReceivable
{
    public string Custno { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string CustName { get; set; } = null!;

    public string? Entitydesc { get; set; }

    public string Invno { get; set; } = null!;

    public DateTime Invdate { get; set; }

    public decimal? Current { get; set; }

    public decimal? AgedTotal { get; set; }

    public decimal? Over30 { get; set; }

    public decimal? Over60 { get; set; }

    public decimal? Over90 { get; set; }

    public decimal? Over120 { get; set; }

    public decimal? Total { get; set; }

    public int? Numdays { get; set; }

    public string? Empno { get; set; }

    public string? Invoicer { get; set; }
}
