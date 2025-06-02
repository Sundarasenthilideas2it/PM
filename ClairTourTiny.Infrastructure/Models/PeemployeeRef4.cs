using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeemployeeRef4
{
    public string Ref4 { get; set; } = null!;

    public string Ref4description { get; set; } = null!;

    public bool IncludeInAbraPayroll { get; set; }

    public bool? Subcontractor { get; set; }

    public bool IncludeInJobCosting { get; set; }

    public virtual ICollection<DivisionPayrollTypeBurdenRate> DivisionPayrollTypeBurdenRates { get; set; } = new List<DivisionPayrollTypeBurdenRate>();
}
