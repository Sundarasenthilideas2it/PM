using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PjjobbudexpA
{
    public string? Entityno { get; set; }

    public DateTime? ChangeDate { get; set; }

    public int? Seqno { get; set; }

    public string? Expcd { get; set; }

    public string? Partno { get; set; }

    public string? Partrev { get; set; }

    public string? Partentityno { get; set; }

    public int? LineNo { get; set; }

    public DateTime? Trandate { get; set; }

    public DateTime? Todate { get; set; }

    public decimal? EstUnitAmount { get; set; }

    public int? EstQty { get; set; }

    public decimal? EstAmount { get; set; }

    public decimal? EstRevAmount { get; set; }

    public decimal? EstRevTotal { get; set; }

    public string? MfgNo { get; set; }

    public string? MfgDesc { get; set; }

    public double? Markup { get; set; }

    public int? QuantityToSubhire { get; set; }

    public string? NoteInternal { get; set; }

    public double? PriceLevelValue { get; set; }

    public string? Matrixcd { get; set; }

    public DateTime AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
