using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuickReportMigration20250429
{
    public string? OrderNo { get; set; }

    public string? PartNo { get; set; }

    public string? Description { get; set; }

    public string? LineNo { get; set; }

    public string? ReleaseNo { get; set; }

    public string? Contract { get; set; }

    public decimal? BuyUnitPrice { get; set; }

    public decimal? CurrencyRate { get; set; }

    public string? CurrencyCode { get; set; }

    public string? DestinationId { get; set; }

    public string? InternalDestination { get; set; }

    public string? PurchaseSite { get; set; }

    public string? LocationNo { get; set; }

    public string? LineNoteText { get; set; }

    public string? PoNoteText { get; set; }

    public string? InvoicingSupplier { get; set; }

    public string? SupplierName { get; set; }

    public decimal? QtyOnOrder { get; set; }

    public decimal? BuyQtyDue { get; set; }

    public decimal? OriginalQty { get; set; }

    public DateTime? DateEntered { get; set; }

    public decimal? InvQtyArrived { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public DateTime? ArrivalDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? Warehouse { get; set; }

    public decimal? QtyOnhand { get; set; }

    public string? ObjectGroup { get; set; }

    public string? PurchaseGroup { get; set; }

    public string? ReceiptState { get; set; }

    public string? PoState { get; set; }

    public decimal? FinesseQty { get; set; }
}
