using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class VenueType
{
    public string VenueCode { get; set; } = null!;

    public string VenueDesc { get; set; } = null!;

    public int? SizeSort { get; set; }

    public string? ShortName { get; set; }

    public decimal? RevOpPerShowLow { get; set; }

    public decimal? RevOpPerShowHigh { get; set; }

    public decimal? OarevOpPerShowLow { get; set; }

    public decimal? OarevOpPerShowHigh { get; set; }

    public virtual ICollection<PollstarNewVenueTypeConversion> PollstarNewVenueTypeConversions { get; set; } = new List<PollstarNewVenueTypeConversion>();

    public virtual ICollection<PollstarVenuesVenueType> PollstarVenuesVenueTypes { get; set; } = new List<PollstarVenuesVenueType>();

    public virtual ICollection<SongkickVenuesVenueType> SongkickVenuesVenueTypes { get; set; } = new List<SongkickVenuesVenueType>();
}
