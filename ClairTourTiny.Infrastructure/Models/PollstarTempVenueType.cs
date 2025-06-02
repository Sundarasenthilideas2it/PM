using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarTempVenueType
{
    public int VenueId { get; set; }

    public string VenueTypeDesc { get; set; } = null!;

    public bool IsPrimary { get; set; }
}
