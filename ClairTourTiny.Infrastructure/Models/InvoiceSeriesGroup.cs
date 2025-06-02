using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceSeriesGroup
{
    public string Entityno { get; set; } = null!;

    public int InvoiceTemplateId { get; set; }

    public int InvoiceTemplateGroupId { get; set; }

    public string InvoiceGroupName { get; set; } = null!;

    public int SortOrder { get; set; }

    public string Notes { get; set; } = null!;

    public virtual InvoiceSeries InvoiceSeries { get; set; } = null!;

    public virtual ICollection<Rfi> Rfis { get; set; } = new List<Rfi>();
}
