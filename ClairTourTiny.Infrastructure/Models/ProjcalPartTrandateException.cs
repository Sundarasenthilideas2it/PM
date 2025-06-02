using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjcalPartTrandateException
{
    public string Entityno { get; set; } = null!;

    public DateTime Trandate { get; set; }

    public long? CountBig { get; set; }
}
