using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PatTestDevice
{
    public string TestDevice { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual ICollection<PatTestResult> PatTestResults { get; set; } = new List<PatTestResult>();
}
