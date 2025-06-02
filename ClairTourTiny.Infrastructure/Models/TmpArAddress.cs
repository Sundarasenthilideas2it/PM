using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArAddress
{
    public int IdAddress { get; set; }

    public int? IdSalutation { get; set; }

    public string? Company { get; set; }

    public string? Surname { get; set; }

    public string? FirstName { get; set; }

    public string? Street { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public string? Phone { get; set; }

    public string? PhoneCompany { get; set; }

    public string? PhoneMobile { get; set; }

    public string? PhonePrivate { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Wwwadress { get; set; }

    public string? Comment { get; set; }

    public byte? Social { get; set; }

    public decimal? AllowanceFactor { get; set; }

    public string? Debtornumber { get; set; }

    public string? Vendornumber { get; set; }

    public string? Number { get; set; }

    public string? VatId { get; set; }

    public string? CustomNumber { get; set; }

    public int? IdPaymentCondition { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public string? Custom3 { get; set; }

    public decimal? Custom4 { get; set; }

    public decimal? Custom5 { get; set; }

    public int? IdCountry { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? Birthplace { get; set; }

    public string? PassportNumber { get; set; }

    public int? BlockIndicator { get; set; }

    public string? State { get; set; }

    public bool? AlwaysDisplayResource { get; set; }

    public string? Messenger { get; set; }

    public string? PicturePath { get; set; }

    public Guid? RmBizIdMember { get; set; }

    public int? IdInvoiceAddress { get; set; }

    public int? IdDeliveryAddress { get; set; }

    public string? Name2 { get; set; }

    public bool? FixRealAllowanceFactor { get; set; }

    public string? CommercialRegisterNumber { get; set; }

    public string? CountyCourt { get; set; }

    public string? TaxNumber { get; set; }

    public int? IdPriceList { get; set; }

    public string? Street2 { get; set; }

    public string? Street3 { get; set; }

    public string? MiddleName { get; set; }

    public string? SocialSecurityNumber { get; set; }

    public string? County { get; set; }

    public int? IdUserCreated { get; set; }

    public int? IdUserUpdated { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? IdAddressResourceType { get; set; }

    public Guid? PartyAddressGuid { get; set; }

    public int? IdObjectParty { get; set; }

    public int? PolicyFlag { get; set; }

    public int? IdDefaultCompany { get; set; }

    public Guid? IdRmmember { get; set; }

    public string? Rmcaption { get; set; }

    public int? IdDefaultCurrency { get; set; }

    public int? IdCrmuser { get; set; }

    public int? IdPaymentConditionSupplier { get; set; }

    public decimal? AllowanceFactorSales { get; set; }

    public int? IdShortCutDefaultPicture { get; set; }

    public bool? IgnoreAvblCheck { get; set; }
}
