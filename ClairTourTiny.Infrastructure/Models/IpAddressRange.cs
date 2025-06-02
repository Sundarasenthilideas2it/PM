using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IpAddressRange
{
    public string RangeType { get; set; } = null!;

    public string RangeDesc { get; set; } = null!;

    public int FirstOctetStart { get; set; }

    public int SecondOctetStart { get; set; }

    public int ThirdOctetStart { get; set; }

    public int FourthOctetStart { get; set; }

    public int FirstOctetEnd { get; set; }

    public int SecondOctetEnd { get; set; }

    public int ThirdOctetEnd { get; set; }

    public int FourthOctetEnd { get; set; }

    public string Subnet { get; set; } = null!;

    public virtual ICollection<AllocatedDeviceIpAddress> AllocatedDeviceIpAddresses { get; set; } = new List<AllocatedDeviceIpAddress>();

    public virtual ICollection<Inpart> Inparts { get; set; } = new List<Inpart>();
}
