using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class In2InvoiceTaxV
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public string Entityno { get; set; } = null!;

    public int InvoiceTemplateId { get; set; }

    public DateTime StartDate { get; set; }

    public int InvoicingTaxGroupId { get; set; }

    public string TaxTypeKey { get; set; } = null!;

    public double Rate { get; set; }

    public double TaxAmount { get; set; }

    public string? Acctcd { get; set; }
}
