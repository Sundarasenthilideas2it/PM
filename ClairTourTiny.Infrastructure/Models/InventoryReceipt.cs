using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InventoryReceipt
{
    public string OrderNo { get; set; } = null!;

    public string PartNumber { get; set; } = null!;

    public int? Qty { get; set; }

    public DateTime? Updated { get; set; }

    public string LineNo { get; set; } = null!;

    public string ReleaseNo { get; set; } = null!;
}
