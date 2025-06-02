using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SongkickEvent
{
    public DateTime PlayDate { get; set; }

    public int ArtistId { get; set; }

    public int VenueId { get; set; }

    public DateTime DateCreated { get; set; }

    public string ActCode { get; set; } = null!;

    public bool? Cancelled { get; set; }

    public string? EventType { get; set; }

    public string? EventName { get; set; }

    public virtual SongkickArtist Artist { get; set; } = null!;

    public virtual SongkickVenue Venue { get; set; } = null!;
}
