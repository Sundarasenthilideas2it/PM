using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoicingTaxGroup
{
    public int InvoicingTaxGroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<InvoiceSeries> InvoiceSeries { get; set; } = new List<InvoiceSeries>();

    public virtual ICollection<InvoiceSeriesStagingVault> InvoiceSeriesStagingVaultInvoicingTaxGroups { get; set; } = new List<InvoiceSeriesStagingVault>();

    public virtual ICollection<InvoiceSeriesStagingVault> InvoiceSeriesStagingVaultOInvoicingTaxGroups { get; set; } = new List<InvoiceSeriesStagingVault>();

    public virtual ICollection<InvoicingTaxGroupType> InvoicingTaxGroupTypes { get; set; } = new List<InvoicingTaxGroupType>();

    public virtual ICollection<Oelocation> Oelocations { get; set; } = new List<Oelocation>();
}
