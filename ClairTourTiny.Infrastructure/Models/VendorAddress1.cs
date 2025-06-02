using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class VendorAddress1
{
    public string Vendno { get; set; } = null!;

    public string VendorName { get; set; } = null!;

    public string Ap1099Ind { get; set; } = null!;

    public string Paytermscd { get; set; } = null!;

    public string BuyerCode { get; set; } = null!;

    public string Bank { get; set; } = null!;

    public string Taxid { get; set; } = null!;

    public string Activeind { get; set; } = null!;

    public DateTime Lastactivity { get; set; }

    public string VendCustno { get; set; } = null!;

    public string SiteNo { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Email2 { get; set; }

    public string Phone { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Currencycd { get; set; } = null!;

    public string? Notes { get; set; }

    public string? VatidentificationNumber { get; set; }

    public string? Vatstatus { get; set; }

    public string? Abnnumber { get; set; }

    public string SearchString { get; set; } = null!;
}
