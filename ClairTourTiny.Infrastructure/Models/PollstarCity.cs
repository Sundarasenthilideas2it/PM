using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarCity
{
    public int CityId { get; set; }

    public string Name { get; set; } = null!;

    public string? DisplayName { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public int? StateId { get; set; }

    public string? Url { get; set; }
}
