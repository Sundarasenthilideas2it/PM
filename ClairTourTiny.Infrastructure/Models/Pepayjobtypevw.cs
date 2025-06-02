using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pepayjobtypevw
{
    public string Empno { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string Jobtype { get; set; } = null!;

    public double Payrate { get; set; }

    public string Paytype { get; set; } = null!;
}
