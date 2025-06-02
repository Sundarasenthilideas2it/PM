using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceTaxStagingVaultV
{
    public string? Entityno { get; set; }

    public int? InvoiceTemplateId { get; set; }

    public DateTime? StartDate { get; set; }

    public int? InvoicingTaxGroupId { get; set; }

    public string? TaxTypeKey { get; set; }

    public string? TaxTypeName { get; set; }

    public double? Rate { get; set; }

    public double? TaxAmount { get; set; }
}
