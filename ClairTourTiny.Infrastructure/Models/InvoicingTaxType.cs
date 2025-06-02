using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoicingTaxType
{
    public string TaxTypeKey { get; set; } = null!;

    public string TaxTypeName { get; set; } = null!;

    /// <summary>
    /// if rate = 0 tax is manually calculated by the user.  if rate &gt; 0 the tax is a fixed rate.
    /// </summary>
    public double? Rate { get; set; }

    public virtual ICollection<ClairTourTaxCodesToSyproTaxCodesMapping> ClairTourTaxCodesToSyproTaxCodesMappings { get; set; } = new List<ClairTourTaxCodesToSyproTaxCodesMapping>();

    public virtual ICollection<Currency> Currencies { get; set; } = new List<Currency>();

    public virtual ICollection<Glentity> Glentities { get; set; } = new List<Glentity>();

    public virtual ICollection<InvoicingTaxGroupType> InvoicingTaxGroupTypes { get; set; } = new List<InvoicingTaxGroupType>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1 { get; set; } = new List<PurchaseOrder1>();
}
