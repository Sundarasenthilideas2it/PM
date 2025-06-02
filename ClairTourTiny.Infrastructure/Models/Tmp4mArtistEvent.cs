using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Tmp4mArtistEvent
{
    public long? ArtistId { get; set; }

    public DateOnly PlayDate { get; set; }

    public string? Country { get; set; }
}
