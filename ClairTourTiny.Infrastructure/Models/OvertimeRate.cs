using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class OvertimeRate
{
    public string RateType { get; set; } = null!;

    public string RateDesc { get; set; } = null!;

    public double Rate { get; set; }

    public byte DisplayOrder { get; set; }

    public virtual ICollection<ProjectEmployeeOvertimeRate> ProjectEmployeeOvertimeRates { get; set; } = new List<ProjectEmployeeOvertimeRate>();
}
