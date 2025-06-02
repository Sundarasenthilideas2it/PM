using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PatTestType
{
    public string TestType { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual ICollection<PatTestResult> PatTestResults { get; set; } = new List<PatTestResult>();
}
