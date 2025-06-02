using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TaxType
{
    public int InvoicingTaxGroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public bool IsActive { get; set; }

    public string TaxTypeKey { get; set; } = null!;

    public string TaxTypeName { get; set; } = null!;

    public double? Rate { get; set; }
}
