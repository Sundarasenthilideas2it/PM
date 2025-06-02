using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class In2InvoiceSplit
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Entityno { get; set; } = null!;

    public int InvoiceSeriesId { get; set; }

    public int InvoiceSplitId { get; set; }

    public DateTime ProjectedInvoiceDate { get; set; }

    public bool? SplitEvenly { get; set; }

    public double? FixedAmount { get; set; }

    public double? Percent { get; set; }

    public string Type { get; set; } = null!;

    public double? TotalToDelete { get; set; }

    public bool IsInvoiced { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateOnly InvoiceDate { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;

    public virtual InvoiceSplitType TypeNavigation { get; set; } = null!;
}
