using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TempQuickReportPoLine
{
    public string? C1OrderNo { get; set; }

    public string? C2PartNo { get; set; }

    public string? C3Description { get; set; }

    public string? C4LineNo { get; set; }

    public string? C5ReleaseNo { get; set; }

    public string? C6Contract { get; set; }

    public double? C7BuyUnitPrice { get; set; }

    public double? C8CurrencyRate { get; set; }

    public string? C9DestinationId { get; set; }

    public string? C10InternalDestination { get; set; }

    public string? C11PurchaseSite { get; set; }

    public string? C12LocationNo { get; set; }

    public string? C13LineNoteText { get; set; }

    public string? C14PoNoteText { get; set; }

    public string? C15InvoicingSupplier { get; set; }

    public string? C16SupplierName { get; set; }

    public string? C17QtyOnOrder { get; set; }

    public long? C18BuyQtyDue { get; set; }

    public long? C19OriginalQty { get; set; }

    public DateTime? C20DateEntered { get; set; }

    public string? C21InvQtyArrived { get; set; }

    public string? C22ApprovedDate { get; set; }

    public string? C23ArrivalDate { get; set; }

    public string? C24DeliveryDate { get; set; }

    public string? C25Warehouse { get; set; }

    public string? C26QtyOnhand { get; set; }

    public string? C27PurchaseGroup { get; set; }

    public string? C28ReceiptState { get; set; }

    public string? C29PoState { get; set; }

    public long? C30FinesseQty { get; set; }
}
