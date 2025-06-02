using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SysproTransferPurchaseOrderQuantity
{
    public string PurchaseOrder { get; set; } = null!;

    public decimal Line { get; set; }

    public string StockCode { get; set; } = null!;

    public string StockDesc { get; set; } = null!;

    public double QtyToReceive { get; set; }

    public DateTime DateTimePutIntoServiceUtc { get; set; }

    public DateTime? DateTimeTransferredInSysproUtc { get; set; }

    public string? Apinvoice { get; set; }

    public DateTime? MlatestDueDate { get; set; }
}
