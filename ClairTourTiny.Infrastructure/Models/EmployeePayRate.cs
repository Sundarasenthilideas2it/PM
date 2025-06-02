using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeePayRate
{
    public string Empno { get; set; } = null!;

    public string JobType { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public double HourlyRate { get; set; }

    public string? Currency { get; set; }

    public string? Note { get; set; }

    public virtual Peemployee EmpnoNavigation { get; set; } = null!;

    public virtual Pejob JobTypeNavigation { get; set; } = null!;
}
