using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DeviceProperty
{
    public string Partno { get; set; } = null!;

    public string? UniqueNo { get; set; }

    public string SerialNo { get; set; } = null!;

    public int Seqno { get; set; }

    public string? Value { get; set; }

    public string? Note { get; set; }

    public int IdCategory { get; set; }

    public string CategoryDesc { get; set; } = null!;

    public int IdPropertyType { get; set; }

    public string PropertyTypeDescription { get; set; } = null!;

    public string PropertyTypeShortDesc { get; set; } = null!;
}
