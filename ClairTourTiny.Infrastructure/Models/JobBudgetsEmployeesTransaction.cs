using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class JobBudgetsEmployeesTransaction
{
    public string Src { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Engactivecd { get; set; } = null!;

    public string Jobtype { get; set; } = null!;

    public DateTime? Fromdate { get; set; }

    public int? Qty { get; set; }
}
