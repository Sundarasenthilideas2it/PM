using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPePayrollRunsWeekly
{
    public DateTime PayrollRunDate { get; set; }

    public string Userid { get; set; } = null!;

    public virtual ICollection<TmpPePayrollRunDataWeekly> TmpPePayrollRunDataWeeklyValidFromNavigations { get; set; } = new List<TmpPePayrollRunDataWeekly>();

    public virtual ICollection<TmpPePayrollRunDataWeekly> TmpPePayrollRunDataWeeklyValidToNavigations { get; set; } = new List<TmpPePayrollRunDataWeekly>();
}
