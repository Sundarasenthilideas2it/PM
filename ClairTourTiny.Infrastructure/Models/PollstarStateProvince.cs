using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarStateProvince
{
    public int Id { get; set; }

    public string StateProvince { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string? Region { get; set; }

    public string? Countrycode { get; set; }

    public virtual Country? CountrycodeNavigation { get; set; }
}
