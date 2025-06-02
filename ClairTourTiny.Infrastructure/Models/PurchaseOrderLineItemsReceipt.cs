using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PurchaseOrderLineItemsReceipt
{
    public int IdPurchaseOrderReceipt { get; set; }

    public int Ponumber { get; set; }

    public string UserName { get; set; } = null!;

    public int LineItemNo { get; set; }

    public DateTime EnterDateUtc { get; set; }

    public double? QtyRecieved { get; set; }

    public string? DeliveryNote { get; set; }

    public virtual PurchaseOrderLineItems PurchaseOrderLineItem { get; set; } = null!;

    public virtual Pjtfrusr UserNameNavigation { get; set; } = null!;
}
