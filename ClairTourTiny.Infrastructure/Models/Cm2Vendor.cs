using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Cm2Vendor
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string? Vendno { get; set; }

    public string? VendorName { get; set; }

    public string? Ap1099Ind { get; set; }

    public string? Parent { get; set; }

    public string? Paytermscd { get; set; }

    public string? Bank { get; set; }

    public string? Taxid { get; set; }

    public bool Activeind { get; set; }

    public string? SiteNo { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zipcode { get; set; }

    public string? Country { get; set; }

    public string? Phone { get; set; }

    public string? Contact { get; set; }

    public string? Extension { get; set; }

    public string? Telex { get; set; }

    public string? Usenet { get; set; }

    public string? Email2 { get; set; }

    public string? Fax { get; set; }

    public string? Voicemail { get; set; }

    public string? Currencycd { get; set; }

    public string? Notes { get; set; }

    public int? IdLanguage { get; set; }

    public string? VatidentificationNumber { get; set; }

    public string? Vatstatus { get; set; }

    public string? Abnnumber { get; set; }

    public double? Discount1 { get; set; }

    public double? Discount2 { get; set; }
}
