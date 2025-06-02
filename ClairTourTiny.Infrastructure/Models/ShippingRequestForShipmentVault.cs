using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingRequestForShipmentVault
{
    public string Entityno { get; set; } = null!;

    public DateTime ShipDate { get; set; }

    public string ServiceTypeDisplayName { get; set; } = null!;

    public string? BillingCompany { get; set; }

    public string? OtherBillName { get; set; }

    public string? OtherBillAcctNo { get; set; }

    public string? RecipientName { get; set; }

    public string? RecipientPhone { get; set; }

    public string? RecipientEmail { get; set; }

    public string? DescriptionOfGoods { get; set; }

    public string? DestinationName { get; set; }

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? CountryCode { get; set; }

    public string? Province { get; set; }

    public string? DestinationPhone { get; set; }

    public int ExpenseTypeDetailCode { get; set; }

    public string? Note { get; set; }

    public string? EntitynoRef { get; set; }

    public string DestinationTypeCode { get; set; } = null!;

    public string? Instructions { get; set; }

    public string? BookingNo { get; set; }

    public string? PickUpNo { get; set; }

    public string? QuoteNo { get; set; }

    public decimal? Amount { get; set; }

    public string? AirBillNo { get; set; }

    public string? SenderUsername { get; set; }

    public bool RequireReceiptSignature { get; set; }

    public string? SpecialAttention { get; set; }

    public bool? Inactive { get; set; }

    public int? IdShippingRequest { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ShippingDestinationType DestinationTypeCodeNavigation { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;

    public virtual ShippingExpenseTypeDetail ExpenseTypeDetailCodeNavigation { get; set; } = null!;

    public virtual Pjtfrusr? SenderUsernameNavigation { get; set; }
}
