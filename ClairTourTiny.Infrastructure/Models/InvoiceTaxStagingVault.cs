using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceTaxStagingVault
{
    public short? Spid { get; set; }

    public string? Entityno { get; set; }

    public int? InvoiceTemplateId { get; set; }

    public DateTime? StartDate { get; set; }

    public int? InvoicingTaxGroupId { get; set; }

    public string TaxTypeKey { get; set; } = null!;

    public string? TaxTypeName { get; set; }

    public double? Rate { get; set; }

    public double? TaxAmount { get; set; }

    public virtual InvoicingTaxGroupType? InvoicingTaxGroupType { get; set; }
}
