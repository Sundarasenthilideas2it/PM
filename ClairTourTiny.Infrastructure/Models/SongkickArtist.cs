using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SongkickArtist
{
    public int ArtistId { get; set; }

    public string ArtistName { get; set; } = null!;

    public string? Genre { get; set; }

    public DateTime DateCreated { get; set; }

    public string? CrmleadUrl { get; set; }

    public virtual ICollection<SongkickEvent> SongkickEvents { get; set; } = new List<SongkickEvent>();

    public virtual ICollection<PollstarArtist> PollstarArtists { get; set; } = new List<PollstarArtist>();
}
