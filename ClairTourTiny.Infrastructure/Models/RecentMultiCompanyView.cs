using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RecentMultiCompanyView
{
    public string UserName { get; set; } = null!;

    public string Companies { get; set; } = null!;

    public DateTime LastViewed { get; set; }

    public int ViewCount { get; set; }
}
