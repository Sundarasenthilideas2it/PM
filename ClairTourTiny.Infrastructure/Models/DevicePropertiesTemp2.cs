using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DevicePropertiesTemp2
{
    public string Partno { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public int IdPropertyType { get; set; }

    public int Seqno { get; set; }

    public string? Value { get; set; }

    public string? Note { get; set; }

    public string UniqueNo { get; set; } = null!;

    public bool? Resolved { get; set; }
}
