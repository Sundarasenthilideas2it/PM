using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuickReportInventoryMigration20250416
{
    public string? OrderNo { get; set; }

    public string? PartNo { get; set; }

    public string? LineNo { get; set; }

    public string? ReleaseNo { get; set; }

    public string? Description { get; set; }

    public string? SerialNo { get; set; }

    public long? QtyOnhand { get; set; }

    public string? LotBatchNo { get; set; }

    public long? InvQtyArrived { get; set; }

    public long? FinesseQty { get; set; }
}
