using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarEvent
{
    public DateTime PlayDate { get; set; }

    public int ArtistId { get; set; }

    public int VenueId { get; set; }

    public DateTime DateCreated { get; set; }

    public string ActCode { get; set; } = null!;

    public bool? Cancelled { get; set; }

    public int? StateId { get; set; }

    public int? EventId { get; set; }

    public virtual PollstarArtist Artist { get; set; } = null!;

    public virtual PollstarVenue Venue { get; set; } = null!;
}
