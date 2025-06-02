using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectEmployeeOvertimeRate
{
    public string Empno { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Jobtype { get; set; } = null!;

    public DateTime Fromdate { get; set; }

    public string RateType { get; set; } = null!;

    public double Hours { get; set; }

    public virtual Pjempassign Pjempassign { get; set; } = null!;

    public virtual OvertimeRate RateTypeNavigation { get; set; } = null!;
}
