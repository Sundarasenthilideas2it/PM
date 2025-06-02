using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceSplitTemplateItem
{
    public int TemplateId { get; set; }

    public int ItemId { get; set; }

    public string Type { get; set; } = null!;

    public double? Value { get; set; }

    public bool? SplitEvenly { get; set; }

    public double? FixedAmount { get; set; }

    public double? Percent { get; set; }

    public virtual InvoiceSplitTemplate Template { get; set; } = null!;
}
