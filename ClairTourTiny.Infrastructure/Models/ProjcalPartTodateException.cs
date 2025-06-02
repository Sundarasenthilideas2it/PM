using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjcalPartTodateException
{
    public string Entityno { get; set; } = null!;

    public DateTime Todate { get; set; }

    public long? CountBig { get; set; }
}
