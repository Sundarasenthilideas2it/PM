using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarSongkickVenue
{
    public int? PollstarVenueId { get; set; }

    public int? SongkickVenueId { get; set; }

    public string? VenueName { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? StateName { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? CountryCode { get; set; }

    public string? CallingCode { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public DateTime? DateCreated { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public int? MetroAreaId { get; set; }

    public string? Description { get; set; }

    public int? Capacity { get; set; }

    public string? Source { get; set; }
}
