using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SysproTransferSalesOrderQuantity
{
    public string SalesOrder { get; set; } = null!;

    public decimal SalesOrderLine { get; set; }

    public string StockCode { get; set; } = null!;

    public string StockDesc { get; set; } = null!;

    public double QtyToDispatch { get; set; }

    public DateTime DateTimePutIntoServiceUtc { get; set; }

    public DateTime? DateTimeTransferredInSysproUtc { get; set; }

    public DateTime? MlineShipDate { get; set; }
}
