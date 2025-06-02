using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Cm2Customer
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string? Custno { get; set; }

    public string? Subno { get; set; }

    public string? BillToName { get; set; }

    public string? Contact { get; set; }

    public string? Attention { get; set; }

    public string? Phone { get; set; }

    public string? Ext { get; set; }

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? Addr3 { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? Taxexempt { get; set; }

    public string? TaxexemptNo { get; set; }

    public string? Currencycd { get; set; }

    public string? Telex { get; set; }

    public string? Usenet { get; set; }

    public string? Email2 { get; set; }

    public string? Fax { get; set; }

    public string? Voicemail { get; set; }

    public string? DealNo { get; set; }

    public string? Paytermscd { get; set; }

    public string? Shipno { get; set; }

    public string? ShipToName { get; set; }

    public string? ShipContact { get; set; }

    public string? ShipAttention { get; set; }

    public string? ShipPhone { get; set; }

    public string? ShipExt { get; set; }

    public string? ShipAddr1 { get; set; }

    public string? ShipAddr2 { get; set; }

    public string? ShipAddr3 { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipCounty { get; set; }

    public string? ShipState { get; set; }

    public string? ShipZip { get; set; }

    public string? ShipCountry { get; set; }

    public string? TaxCode { get; set; }

    public double? Tax2 { get; set; }

    public double? Tax3 { get; set; }

    public string? Matrixcd { get; set; }

    public double? Discount { get; set; }

    public string? ShipTelex { get; set; }

    public string? ShipUsenet { get; set; }

    public string? ShipEmail2 { get; set; }

    public string? ShipFax { get; set; }

    public string? ShipVoicemail { get; set; }

    public string? Salesmancd { get; set; }

    public string? ShipDealNo { get; set; }

    public string? Notes { get; set; }

    public string? Accountno { get; set; }

    public bool? Activeind { get; set; }

    public int? IdLanguage { get; set; }

    public string? VatidentificationNumber { get; set; }

    public string? Vatstatus { get; set; }

    public string? Abnnumber { get; set; }

    public string? InvoiceFolder { get; set; }

    public Guid? FileStorageGuid { get; set; }
}
