using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ExpensePeriodType
{
    public string PeriodTypeCode { get; set; } = null!;

    public string PeriodTypeDesc { get; set; } = null!;

    public int? Sortorder { get; set; }

    public virtual ICollection<Pjjobexpense> Pjjobexpenses { get; set; } = new List<Pjjobexpense>();
}
