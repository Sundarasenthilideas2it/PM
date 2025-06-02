using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarSongkickVenueLink
{
    public int PollstarVenueId { get; set; }

    public int SongkickVenueId { get; set; }

    public virtual PollstarVenue PollstarVenue { get; set; } = null!;
}
