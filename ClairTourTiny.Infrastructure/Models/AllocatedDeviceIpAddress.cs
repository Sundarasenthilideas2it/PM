using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllocatedDeviceIpAddress
{
    public string RangeType { get; set; } = null!;

    public string Subnet { get; set; } = null!;

    public byte[] IpaddressBinary { get; set; } = null!;

    public string ServerName { get; set; } = null!;

    public DateTimeOffset? AddedIntoService { get; set; }

    public bool CanBeSelected { get; set; }

    public virtual IpAddressRange RangeTypeNavigation { get; set; } = null!;
}
