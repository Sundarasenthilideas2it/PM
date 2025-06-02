using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PePayPeriod
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public virtual Day EndDateNavigation { get; set; } = null!;

    public virtual ICollection<PePayrollRunDatum> PePayrollRunData { get; set; } = new List<PePayrollRunDatum>();

    public virtual Day StartDateNavigation { get; set; } = null!;
}
