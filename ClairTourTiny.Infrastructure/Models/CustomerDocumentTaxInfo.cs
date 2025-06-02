using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CustomerDocumentTaxInfo
{
    public string CustomerId { get; set; } = null!;

    public string AddressId { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string SupplyCountry { get; set; } = null!;

    public string DeliveryCountry { get; set; } = null!;

    public string? TaxIdType { get; set; }

    public string? VatNo { get; set; }

    public DateTime? ValidatedDate { get; set; }

    public double Rowversion { get; set; }

    public string Rowkey { get; set; } = null!;

    public string? TaxOfficeId { get; set; }
}
