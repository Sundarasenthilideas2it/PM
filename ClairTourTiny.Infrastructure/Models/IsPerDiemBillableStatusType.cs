using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IsPerDiemBillableStatusType
{
    public string IsPerDiemBillableStatusCode { get; set; } = null!;

    public string IsPerDiemBillableStatusDesc { get; set; } = null!;

    public virtual ICollection<Pjempassign> Pjempassigns { get; set; } = new List<Pjempassign>();
}
