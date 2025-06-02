using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class In2RfiV
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Entityno { get; set; } = null!;

    public int Seq { get; set; }

    public int? InvoiceTemplateId { get; set; }

    public int? InvoiceTemplateGroupId { get; set; }

    public int? Sortorder { get; set; }

    public short? SplitCount { get; set; }

    public short? SplitCountInvoiced { get; set; }
}
