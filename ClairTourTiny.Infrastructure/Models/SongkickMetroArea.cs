using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SongkickMetroArea
{
    public int Id { get; set; }

    public string Metro { get; set; } = null!;

    public string? State { get; set; }

    public string? Country { get; set; }

    public double? Lat { get; set; }

    public double? Lng { get; set; }

    public string? Region { get; set; }

    public virtual Region? RegionNavigation { get; set; }
}
