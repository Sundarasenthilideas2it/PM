using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class WeekendCrewPrep
{
    public string Empno { get; set; } = null!;

    public string Empname { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public DateTime Date { get; set; }
}
