using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceTax
{
    public string Entityno { get; set; } = null!;

    public int InvoiceTemplateId { get; set; }

    public DateTime StartDate { get; set; }

    public int InvoicingTaxGroupId { get; set; }

    public string TaxTypeKey { get; set; } = null!;

    public double Rate { get; set; }

    public double TaxAmount { get; set; }

    public int InvoiceSeqno { get; set; }

    public string? Acctcd { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual InvoicingTaxGroupType InvoicingTaxGroupType { get; set; } = null!;
}
