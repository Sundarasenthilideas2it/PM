using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SongkickVenuesVenueType
{
    public int VenueId { get; set; }

    public string VenueCode { get; set; } = null!;

    public virtual SongkickVenue Venue { get; set; } = null!;

    public virtual VenueType VenueCodeNavigation { get; set; } = null!;
}
