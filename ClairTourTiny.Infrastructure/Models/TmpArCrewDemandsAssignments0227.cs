using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArCrewDemandsAssignments0227
{
    public string? Type { get; set; }

    public string Jobno { get; set; } = null!;

    public string? Jobdesc { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public decimal? JDemand { get; set; }

    public string? Empno { get; set; }

    public string? EmpType { get; set; }

    public string? ResourceStatus { get; set; }

    public int? JAllocated { get; set; }

    public int? IdResourceAllocationDriver { get; set; }
}
