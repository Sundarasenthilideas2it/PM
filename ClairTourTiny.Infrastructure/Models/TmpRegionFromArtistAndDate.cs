using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpRegionFromArtistAndDate
{
    public int ArtistId { get; set; }

    public int? MaxDdp { get; set; }

    public int? MaxDdn { get; set; }

    public DateTime PlayDate { get; set; }

    public int? DeltaDaysFromPrev { get; set; }

    public int? DeltaDaysFromNext { get; set; }

    public DateTime? StartDate { get; set; }

    public string? Region { get; set; }

    public DateTime EndDate { get; set; }
}
