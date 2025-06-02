using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CommMethod
{
    public string PartyType { get; set; } = null!;

    public string Identity { get; set; } = null!;

    public double CommId { get; set; }

    public string Value { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? MethodDefault { get; set; }

    public string? AddressDefault { get; set; }

    public string? Name { get; set; }

    public string MethodId { get; set; } = null!;

    public string? AddressId { get; set; }

    public DateTime? Rowversion { get; set; }

    public string? Rowkey { get; set; }
}
