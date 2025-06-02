using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarArtistsEventsPerYearMonthInRegion
{
    public int ArtistId { get; set; }

    public int? TheYear { get; set; }

    public int? TheMonth { get; set; }

    public string? EventsPerRegion { get; set; }
}
