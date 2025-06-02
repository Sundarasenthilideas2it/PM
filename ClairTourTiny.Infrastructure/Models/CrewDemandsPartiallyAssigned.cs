using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CrewDemandsPartiallyAssigned
{
    public string Entityno { get; set; } = null!;

    public string Jobtype { get; set; } = null!;

    public int EmplineNo { get; set; }

    public int CrewSize { get; set; }

    public DateTime Fromdate { get; set; }

    public DateTime Todate { get; set; }

    public int Seqno { get; set; }

    public int? AssignedDaysCount { get; set; }

    public long? Assignments { get; set; }
}
