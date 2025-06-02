using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarVenuesVenueType
{
    public int VenueId { get; set; }

    public string VenueCode { get; set; } = null!;

    public virtual PollstarVenue Venue { get; set; } = null!;

    public virtual VenueType VenueCodeNavigation { get; set; } = null!;
}
