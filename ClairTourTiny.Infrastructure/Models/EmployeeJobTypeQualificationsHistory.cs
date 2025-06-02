using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeJobTypeQualificationsHistory
{
    public string Empno { get; set; } = null!;

    public string Jobtype { get; set; } = null!;

    public bool IsDefault { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Peemployee EmpnoNavigation { get; set; } = null!;

    public virtual Day? EndDateNavigation { get; set; }

    public virtual Pejob JobtypeNavigation { get; set; } = null!;

    public virtual Day StartDateNavigation { get; set; } = null!;
}
