using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingDestination
{
    public string? DestinationDetail { get; set; }

    public string? DestinationName { get; set; }

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? CountryCode { get; set; }

    public string? Province { get; set; }

    public string? DestinationPhone { get; set; }

    public bool? Inactive { get; set; }
}
