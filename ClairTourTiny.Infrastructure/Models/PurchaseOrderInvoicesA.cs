using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PurchaseOrderInvoicesA
{
    public int? IdPurchaseOrderInvoice { get; set; }

    public int? IdPurchaseOrder { get; set; }

    public DateTime? InvoiceReceived { get; set; }

    public string? InvoiceNo { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? ShippingAmount { get; set; }

    public decimal? InvoiceAmount { get; set; }

    public string? Currency { get; set; }

    public string? AcctCd { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? PayAuthorizedBy { get; set; }

    public DateTime? PayAuthorizedDate { get; set; }

    public string? PaidBy { get; set; }

    public DateTime? PaidDate { get; set; }

    public Guid? FileStorageGuid { get; set; }

    public string? PostedBy { get; set; }

    public DateTime? PostedDate { get; set; }

    public int? Ponumber { get; set; }

    public DateTime AdateTime { get; set; }

    public string AuserId { get; set; } = null!;

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }
}
