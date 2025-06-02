using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PePayrollRun
{
    public DateTime PayrollRunDate { get; set; }

    public string Userid { get; set; } = null!;

    public virtual ICollection<PePayrollRunDatum> PePayrollRunDatumValidFromNavigations { get; set; } = new List<PePayrollRunDatum>();

    public virtual ICollection<PePayrollRunDatum> PePayrollRunDatumValidToNavigations { get; set; } = new List<PePayrollRunDatum>();
}
