using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IfsexternalInvoiceFormat
{
    public string RecordTypeId { get; set; } = null!;

    public string ColumnId { get; set; } = null!;

    public string? Description { get; set; }

    public long ColumnNo { get; set; }

    public string? FileTemplate { get; set; }
}
