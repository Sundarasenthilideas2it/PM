using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class VendorAddress
{
    public string? VendorId { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string AddressLine4 { get; set; } = null!;

    public string? City { get; set; }

    public string? StateProvince { get; set; }

    public string? Country { get; set; }

    public string? PostalCode { get; set; }

    public string Type { get; set; } = null!;
}
