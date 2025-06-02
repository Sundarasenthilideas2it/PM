using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPePayrollRunDataWeekly
{
    public DateTime ValidFrom { get; set; }

    public DateTime ValidTo { get; set; }

    public DateTime PeriodStart { get; set; }

    public string Empno { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Jobtype { get; set; } = null!;

    public double Payrate { get; set; }

    public string Paytype { get; set; } = null!;

    public double PayMultiplier { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public double AssignedHours { get; set; }

    public double Payamt { get; set; }

    public virtual TmpPePayPeriodsWeekly PeriodStartNavigation { get; set; } = null!;

    public virtual TmpPePayrollRunsWeekly ValidFromNavigation { get; set; } = null!;

    public virtual TmpPePayrollRunsWeekly ValidToNavigation { get; set; } = null!;
}
