using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ZipCode
{
    public string Zip { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public short Gmtoffset { get; set; }

    public bool Dst { get; set; }
}
