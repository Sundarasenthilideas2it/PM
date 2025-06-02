using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DeviceProperty1
{
    public string Partno { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public int IdPropertyType { get; set; }

    public int Seqno { get; set; }

    public string? Value { get; set; }

    public string? Note { get; set; }

    public string UniqueNo { get; set; } = null!;

    public virtual DevicePropertyType IdPropertyTypeNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
