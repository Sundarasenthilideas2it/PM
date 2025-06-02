using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TruckingCompany
{
    public string Vendno { get; set; } = null!;

    public string VendorName { get; set; } = null!;

    public string SiteNo { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Email2 { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Telex { get; set; } = null!;

    public string Currencycd { get; set; } = null!;

    public string Taxid { get; set; } = null!;

    public string? VatidentificationNumber { get; set; }
}
