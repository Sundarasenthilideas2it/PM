using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class In2InvoiceSeriesGroup
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Entityno { get; set; } = null!;

    public int InvoiceTemplateId { get; set; }

    public int InvoiceTemplateGroupId { get; set; }

    public string InvoiceGroupName { get; set; } = null!;

    public int SortOrder { get; set; }

    public string Notes { get; set; } = null!;
}
