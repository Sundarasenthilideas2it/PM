using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SysproTransfersSalesOrder
{
    public string SalesOrder { get; set; } = null!;

    public string StockCode { get; set; } = null!;

    public double QtyToDispatch { get; set; }

    public decimal SalesOrderLine { get; set; }

    public DateTime DateTimePutIntoServiceUtc { get; set; }

    public DateTime? DateTimeTransferredInSysproUtc { get; set; }
}
