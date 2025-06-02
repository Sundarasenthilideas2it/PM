using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoicingTaxGroupType
{
    public int InvoicingTaxGroupId { get; set; }

    public string TaxTypeKey { get; set; } = null!;

    public virtual ICollection<InvoiceTax> InvoiceTaxes { get; set; } = new List<InvoiceTax>();

    public virtual InvoicingTaxGroup InvoicingTaxGroup { get; set; } = null!;

    public virtual InvoicingTaxType TaxTypeKeyNavigation { get; set; } = null!;
}
