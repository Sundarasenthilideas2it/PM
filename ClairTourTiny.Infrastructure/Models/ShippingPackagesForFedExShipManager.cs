using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingPackagesForFedExShipManager
{
    public string? TransactionId { get; set; }

    public string? RecipientCompany { get; set; }

    public string? RecipientName { get; set; }

    public string? RecipientAddress1 { get; set; }

    public string? RecipientAddress2 { get; set; }

    public string? RecipientCity { get; set; }

    public string? RecipientStateProvince { get; set; }

    public string? RecipientPostalCode { get; set; }

    public string RecipientPhoneNumber { get; set; } = null!;

    public string? RecipientCountryCode { get; set; }

    public string? RecipientAccountNo { get; set; }

    public string RecipientEmail { get; set; } = null!;

    public string? SenderCompany { get; set; }

    public string SenderContact { get; set; } = null!;

    public string? SenderAddress1 { get; set; }

    public string? SenderAddress2 { get; set; }

    public string? SenderCity { get; set; }

    public string? SenderStateProvince { get; set; }

    public string? SenderPostalCode { get; set; }

    public string? SenderPhone { get; set; }

    public string? SenderCountryCode { get; set; }

    public string SenderEmail { get; set; } = null!;

    public string? ServiceType { get; set; }

    public string PackageType { get; set; } = null!;

    public DateTime ShipDate { get; set; }

    public double PackageWeight { get; set; }

    public string WeightType { get; set; } = null!;

    public double PackageLength { get; set; }

    public double PackageWidth { get; set; }

    public double PackageHeight { get; set; }

    public string DimensionsType { get; set; } = null!;

    public int PaymentCode { get; set; }

    public string? AccountNo { get; set; }

    public string? BillToAccountNumber { get; set; }

    public int? ReferenceInformation { get; set; }

    public string? CustomerReferenceEntityNo { get; set; }

    public string? CustomerReference { get; set; }

    public int? DepartmentNotes { get; set; }

    public string Ponumber { get; set; } = null!;

    public int? InvoiceNumber { get; set; }

    public string ResidentialDeliveryFlag { get; set; } = null!;

    public int SignatureOption { get; set; }

    public string SignatureRequired { get; set; } = null!;

    public string SaturdayDeliveryFlag { get; set; } = null!;

    public string ShipAlertNotificationFlag { get; set; } = null!;

    public string? ShipmentNotificationEmail1 { get; set; }

    public string? ShipmentNotificationEmail2 { get; set; }

    public string ShipmentNotificationEmail3 { get; set; } = null!;

    public string? TrackingNumber { get; set; }

    public string? MasterTrackingNumber { get; set; }

    public double? BilledWeight { get; set; }

    public double? NetCharge { get; set; }

    public double? TotalCustomerCharge { get; set; }

    public int IdPackage { get; set; }

    public int IdShippingRequest { get; set; }

    public string Entityno { get; set; } = null!;

    public string ServiceTypeDisplayName { get; set; } = null!;

    public string? BillingCompany { get; set; }

    public string? OtherBillName { get; set; }

    public string? DescriptionOfGoods { get; set; }

    public string? EntitynoRef { get; set; }

    public string? Note { get; set; }

    public string? Instructions { get; set; }

    public string? BookingNo { get; set; }

    public string? PickUpNo { get; set; }

    public string? QuoteNo { get; set; }

    public decimal? Amount { get; set; }

    public string? AirBillNo { get; set; }

    public string? SenderUsername { get; set; }
}
