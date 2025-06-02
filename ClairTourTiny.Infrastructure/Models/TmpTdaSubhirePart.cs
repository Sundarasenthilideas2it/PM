using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaSubhirePart
{
    public string? VendorCode { get; set; }

    public string? AdressId { get; set; }

    public string Number { get; set; } = null!;

    public string? FinessePartNo { get; set; }

    public string Caption { get; set; } = null!;

    public decimal? Price { get; set; }

    public int? Rank { get; set; }

    public string? SupplierNumber { get; set; }

    public int IdAddress { get; set; }

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

    public string? VatId { get; set; }

    public string? CustomNumber { get; set; }

    public int? IdPaymentCondition { get; set; }

    public int? IdCountry { get; set; }

    public string? State { get; set; }

    public int? IdInvoiceAddress { get; set; }

    public int? IdDeliveryAddress { get; set; }

    public string? Name2 { get; set; }

    public string? CommercialRegisterNumber { get; set; }

    public int? IdUserCreated { get; set; }

    public int? IdUserUpdated { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? IdContactPrimary { get; set; }

    public int? IdVatType { get; set; }

    public int? IdLanguage { get; set; }

    public string? InvoiceInfo { get; set; }
}
