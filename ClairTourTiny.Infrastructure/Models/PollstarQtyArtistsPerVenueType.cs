using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarQtyArtistsPerVenueType
{
    public string VenueType { get; set; } = null!;

    public int SizeSort { get; set; }

    public int? QtyArtists { get; set; }

    public int? QtyClairArtists { get; set; }
}
