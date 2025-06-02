using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CustomerInfoAddressType
{
    public string CustomerId { get; set; } = null!;

    public string AddressId { get; set; } = null!;

    public string AddressTypeCode { get; set; } = null!;

    public string Party { get; set; } = null!;

    public string DefAddress { get; set; } = null!;

    public string DefaultDomain { get; set; } = null!;

    public string? Rowkey { get; set; }

    public double? Rowversion { get; set; }
}
