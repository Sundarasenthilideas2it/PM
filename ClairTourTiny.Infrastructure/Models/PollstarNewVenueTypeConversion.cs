using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarNewVenueTypeConversion
{
    public string VenueTypeDesc { get; set; } = null!;

    public string? VenueCode { get; set; }

    public virtual VenueType? VenueCodeNavigation { get; set; }
}
