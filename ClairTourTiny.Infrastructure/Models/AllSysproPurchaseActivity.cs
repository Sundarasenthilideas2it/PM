using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllSysproPurchaseActivity
{
    public string Company { get; set; } = null!;

    public string PurchaseOrder { get; set; } = null!;

    public decimal Line { get; set; }

    public string MstockCode { get; set; } = null!;

    public string MstockDes { get; set; } = null!;

    public string Glcode { get; set; } = null!;

    public decimal OrderQty { get; set; }

    public decimal? ReceivedYear { get; set; }

    public decimal? QtyReceivedInYear { get; set; }

    public decimal TotalReceivedQty { get; set; }

    public decimal? DueQty { get; set; }

    public decimal? ReceivedValueInYear { get; set; }

    public decimal? OutstandingCost { get; set; }

    public string? OrderStatus { get; set; }

    public DateTime? OrderEntryDate { get; set; }

    public DateTime? MlatestDueDate { get; set; }

    public string? SupplierName { get; set; }

    public string CustomerPoNumber { get; set; } = null!;

    public string MsalesOrder { get; set; } = null!;

    public string? BuyerName { get; set; }

    public string Warehouse { get; set; } = null!;

    public string? ProductClassDesc { get; set; }

    public decimal Mprice { get; set; }

    public DateTime? MlastReceiptDat { get; set; }

    public string Pocurrency { get; set; } = null!;

    public decimal? BuyExchangeRate { get; set; }

    public decimal? UsditemPrice { get; set; }
}
