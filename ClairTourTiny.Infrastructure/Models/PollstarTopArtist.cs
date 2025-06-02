using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarTopArtist
{
    public int? ArtistId { get; set; }

    public string? ArtistName { get; set; }

    public int? EventCount { get; set; }
}
