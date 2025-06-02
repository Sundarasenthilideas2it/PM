using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PjjobbudexpTemp
{
    public string Entityno { get; set; } = null!;

    public DateTime ChangeDate { get; set; }

    public int Seqno { get; set; }

    public string Expcd { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string Partrev { get; set; } = null!;

    public string Partentityno { get; set; } = null!;

    public int LineNo { get; set; }

    public DateTime Trandate { get; set; }

    public DateTime Todate { get; set; }

    public decimal EstUnitAmount { get; set; }

    public int EstQty { get; set; }

    public decimal EstAmount { get; set; }

    public decimal EstRevAmount { get; set; }

    public decimal EstRevTotal { get; set; }

    public string MfgNo { get; set; } = null!;

    public string MfgDesc { get; set; } = null!;

    public double Markup { get; set; }

    public int? QuantityToSubhire { get; set; }

    public string NoteInternal { get; set; } = null!;

    public double? PriceLevelValue { get; set; }

    public string? Matrixcd { get; set; }

    public bool Resoved { get; set; }

    public bool? SkipRow { get; set; }
}
