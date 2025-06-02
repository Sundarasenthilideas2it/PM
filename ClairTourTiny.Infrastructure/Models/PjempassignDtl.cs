using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PjempassignDtl
{
    public string Entityno { get; set; } = null!;

    public int? Demand { get; set; }

    public DateTime Fromdate { get; set; }

    public DateTime Todate { get; set; }

    public string Jobtype { get; set; } = null!;

    public int EmplineNo { get; set; }
}
