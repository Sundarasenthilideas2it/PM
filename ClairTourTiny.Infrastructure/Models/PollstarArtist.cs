using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarArtist
{
    public int ArtistId { get; set; }

    public string ArtistName { get; set; } = null!;

    public string? Genre { get; set; }

    public DateTime DateCreated { get; set; }

    public string? CrmleadUrl { get; set; }

    public virtual ICollection<Glentity> Glentities { get; set; } = new List<Glentity>();

    public virtual ICollection<PollstarEvent> PollstarEvents { get; set; } = new List<PollstarEvent>();

    public virtual ICollection<PollstarReaderHideArtistUntil1> PollstarReaderHideArtistUntil1s { get; set; } = new List<PollstarReaderHideArtistUntil1>();

    public virtual ICollection<SongkickArtist> SongkickArtists { get; set; } = new List<SongkickArtist>();
}
