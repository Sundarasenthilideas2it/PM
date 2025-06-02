using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SysproPurchaseActivity
{
    public string PurchaseOrder { get; set; } = null!;

    public decimal Line { get; set; }

    public DateTime? OrderEntryDate { get; set; }

    public DateTime? MlatestDueDate { get; set; }

    public string? SupplierName { get; set; }

    public string? BuyerName { get; set; }

    public string Branch { get; set; } = null!;

    public string? AcctCd { get; set; }

    public string? ProductClassDesc { get; set; }

    public decimal MorderQty { get; set; }

    public string MstockCode { get; set; } = null!;

    public string MstockDes { get; set; } = null!;

    public decimal Mprice { get; set; }

    public decimal? Linetotal { get; set; }

    public decimal MreceivedQty { get; set; }

    public string OrderLineStatus { get; set; } = null!;

    public string OrderStatus { get; set; } = null!;

    public decimal? DueQty { get; set; }

    public string Pocurrency { get; set; } = null!;

    public decimal? BuyExchangeRate { get; set; }

    public decimal? UsditemPrice { get; set; }

    public decimal? UsdlineTotal { get; set; }
}
