using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Dpro
{
    public byte[] Macaddress { get; set; } = null!;

    public string? SerialNo { get; set; }

    public virtual ICollection<Station> StationDescriptions { get; set; } = new List<Station>();
}
