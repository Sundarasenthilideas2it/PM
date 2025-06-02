using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AssignedCrewStartingToday
{
    public string Division { get; set; } = null!;

    public string Empno { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public string? Company { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public int? Days { get; set; }

    public double Hours { get; set; }

    public double? HoursPerDay { get; set; }

    public string? Status { get; set; }

    public int? Ponumber { get; set; }

    public DateTime? OrderedDate { get; set; }

    public DateTime? CanceledDate { get; set; }
}
