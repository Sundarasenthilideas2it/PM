using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class VPollstarSongkickLinkedEvent
{
    public DateOnly? PlayDate { get; set; }

    public int PollstarArtistId { get; set; }

    public int SongkickArtistId { get; set; }

    public int PollstarVenueId { get; set; }

    public int SongkickVenueId { get; set; }

    public string ActCode { get; set; } = null!;

    public bool? Cancelled { get; set; }

    public int? StateId { get; set; }

    public string? EventType { get; set; }

    public string? EventName { get; set; }

    public string Source { get; set; } = null!;
}
