using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SupplierInfoAddress
{
    public string SupplierId { get; set; } = null!;

    public string AddressId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? EanLocation { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string Party { get; set; } = null!;

    public string DefaultDomain { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string PartyType { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string? Address5 { get; set; }

    public string? Address6 { get; set; }

    public string? ZipCode { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? State { get; set; }

    public int? CommId { get; set; }

    public string? OutputMedia { get; set; }

    public string? SupplierBranch { get; set; }

    public DateTime? Rowversion { get; set; }

    public string? Rowkey { get; set; }
}
