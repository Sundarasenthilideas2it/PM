using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ZebraPrinter
{
    public string PrinterName { get; set; } = null!;

    public string Ipaddress { get; set; } = null!;

    public int Port { get; set; }

    public string? LocationDefault { get; set; }

    public string? Macaddress { get; set; }

    public virtual Warehouse? LocationDefaultNavigation { get; set; }
}
