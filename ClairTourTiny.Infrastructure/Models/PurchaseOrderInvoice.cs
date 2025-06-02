using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public class PurchaseOrderInvoice
{
    public int IdPurchaseOrderInvoice { get; set; }

    public int? IdPurchaseOrder { get; set; }

    public DateTime InvoiceReceived { get; set; }

    public string InvoiceNo { get; set; } = null!;

    public DateOnly InvoiceDate { get; set; }

    public decimal TotalAmount { get; set; }

    public decimal TaxAmount { get; set; }

    public decimal ShippingAmount { get; set; }

    public decimal InvoiceAmount { get; set; }

    public string Currency { get; set; } = null!;

    public string? AcctCd { get; set; }

    public string? Notes { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime ModifiedDate { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public string? PayAuthorizedBy { get; set; }

    public DateTime? PayAuthorizedDate { get; set; }

    public string? PaidBy { get; set; }

    public DateTime? PaidDate { get; set; }

    public Guid? FileStorageGuid { get; set; }

    public string? PostedBy { get; set; }

    public DateTime? PostedDate { get; set; }

    public int Ponumber { get; set; }

    public virtual Glaccount? AcctCdNavigation { get; set; }

    public virtual Pjtfrusr CreatedByNavigation { get; set; } = null!;

    public virtual Pjtfrusr ModifiedByNavigation { get; set; } = null!;

    public virtual Pjtfrusr? PaidByNavigation { get; set; }

    public virtual Pjtfrusr? PayAuthorizedByNavigation { get; set; }

    public virtual PurchaseOrder1 PonumberNavigation { get; set; } = null!;
}
