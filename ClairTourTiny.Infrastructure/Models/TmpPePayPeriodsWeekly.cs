using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPePayPeriodsWeekly
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual Day EndDateNavigation { get; set; } = null!;

    public virtual Day StartDateNavigation { get; set; } = null!;

    public virtual ICollection<TmpPePayrollRunDataWeekly> TmpPePayrollRunDataWeeklies { get; set; } = new List<TmpPePayrollRunDataWeekly>();
}
