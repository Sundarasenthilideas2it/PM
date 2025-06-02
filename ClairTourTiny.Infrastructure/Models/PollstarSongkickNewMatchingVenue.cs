using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarSongkickNewMatchingVenue
{
    public int PollstarVenueId { get; set; }

    public int SongkickVenueId { get; set; }

    public string PollstarVenueName { get; set; } = null!;

    public string SongkickVenueName { get; set; } = null!;

    public string? PollstarAddress1 { get; set; }

    public string? SongkickAddress1 { get; set; }

    public string? PCity { get; set; }

    public string? SCity { get; set; }

    public string? Country { get; set; }

    public string? CountryCode { get; set; }

    public string? CallingCode { get; set; }

    public string? PZip { get; set; }

    public string? SZip { get; set; }

    public decimal? PLat { get; set; }

    public decimal? PLng { get; set; }

    public decimal? SLat { get; set; }

    public decimal? SLng { get; set; }

    public decimal? LatDiff { get; set; }

    public decimal? LngDiff { get; set; }

    public double? Distance { get; set; }

    public int? PsvlPollstarVenueId { get; set; }

    public int? PsvlSongkickVenueId { get; set; }
}
