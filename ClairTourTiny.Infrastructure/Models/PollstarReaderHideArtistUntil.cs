using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarReaderHideArtistUntil
{
    public int PollstarArtistId { get; set; }

    public int SongkickArtistId { get; set; }

    public DateOnly HideUntilDate { get; set; }
}
