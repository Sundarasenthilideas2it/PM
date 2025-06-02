using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarSongkickArtist
{
    public int? PollstarArtistId { get; set; }

    public int? SongkickArtistId { get; set; }

    public string? ArtistName { get; set; }

    public string? Genre { get; set; }

    public string? CrmleadUrl { get; set; }

    public string? Source { get; set; }
}
