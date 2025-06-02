using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarVenue
{
    public int VenueId { get; set; }

    public string VenueName { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? StateName { get; set; }

    public string? Zip { get; set; }

    public string? CountryCode { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public DateTime? DateCreated { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? CountryDesc { get; set; }

    public virtual ICollection<PollstarEvent> PollstarEvents { get; set; } = new List<PollstarEvent>();

    public virtual ICollection<PollstarSongkickVenueLink> PollstarSongkickVenueLinks { get; set; } = new List<PollstarSongkickVenueLink>();

    public virtual PollstarVenuesVenueType? PollstarVenuesVenueType { get; set; }

    public virtual ICollection<ProjectProductionSchedule> ProjectProductionSchedules { get; set; } = new List<ProjectProductionSchedule>();
}
