using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaCrewOrderedOnFinesseProject
{
    public string? Entityno { get; set; }

    public long? Seqno { get; set; }

    public string? Jobtype { get; set; }

    public string? Jobdesc { get; set; }

    public DateOnly? Fromdate { get; set; }

    public DateOnly? Todate { get; set; }

    public int? Quantity { get; set; }

    public double? EstHours { get; set; }

    public double? EstRate { get; set; }

    public decimal? TotalPrice { get; set; }

    public double? EstRevRate { get; set; }

    public decimal? EstRevTotal { get; set; }

    public long? EmplineNo { get; set; }

    public string ResourceType { get; set; } = null!;

    public int IdResourceFunctionAllocation { get; set; }

    public decimal? DaysInAction { get; set; }
}
