using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RecentProject
{
    public string Userid { get; set; } = null!;

    public DateTimeOffset DateOpened { get; set; }

    public string Entityno { get; set; } = null!;
}
