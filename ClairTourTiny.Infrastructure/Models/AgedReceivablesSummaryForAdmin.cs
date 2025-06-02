using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AgedReceivablesSummaryForAdmin
{
    public string Custno { get; set; } = null!;

    public string CustName { get; set; } = null!;

    public string? BillingCompany { get; set; }

    public int? Invno { get; set; }

    public int? Invdate { get; set; }

    public decimal? Current { get; set; }

    public decimal? AgedTotal { get; set; }

    public decimal? Over30 { get; set; }

    public decimal? Over60 { get; set; }

    public decimal? Over90 { get; set; }

    public decimal? Over120 { get; set; }

    public decimal? Total { get; set; }

    public int? Numdays { get; set; }

    public string Name { get; set; } = null!;

    public int Istotal { get; set; }

    public DateTime? LastInvoiceDate { get; set; }

    public string? Amempno { get; set; }

    public string? Aeempno { get; set; }

    public string? Smempno { get; set; }

    public bool HideFromReceivablesReport { get; set; }
}
