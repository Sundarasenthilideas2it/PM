using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceSplit
{
    public string Entityno { get; set; } = null!;

    public int InvoiceSeriesId { get; set; }

    public int InvoiceSplitId { get; set; }

    public DateOnly ProjectedInvoiceDate { get; set; }

    public bool? SplitEvenly { get; set; }

    public double? FixedAmount { get; set; }

    public double? Percent { get; set; }

    public string Type { get; set; } = null!;

    public double? TotalToDelete { get; set; }

    public bool IsInvoiced { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public double? InvoicedTotal { get; set; }

    public DateOnly InvoiceDate { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;

    public virtual InvoiceSplitType TypeNavigation { get; set; } = null!;
}
