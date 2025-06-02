using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaCountryMapping
{
    public int IdCountry { get; set; }

    public string? Caption { get; set; }

    public string? Isocode { get; set; }

    public bool? InnerEu { get; set; }

    public string? PhonePrefix { get; set; }

    public int? IdAddressFormat { get; set; }

    public int? IdContinent { get; set; }

    public string? CaptionLng2 { get; set; }

    public string? CaptionLng3 { get; set; }

    public string? CaptionLng4 { get; set; }

    public string? CaptionLng5 { get; set; }

    public string? CaptionLng6 { get; set; }

    public int? IdLanguage { get; set; }

    public string? Countrycode { get; set; }

    public string? Countrydesc { get; set; }

    public string? Region { get; set; }

    public string? CallingCode { get; set; }

    public bool? SongkickQueryable { get; set; }

    public DateTime? LastSongkickQueryTime { get; set; }

    public int? SongkickRowsUpdatedSoFar { get; set; }

    public int? SongkickMetroAreas { get; set; }
}
