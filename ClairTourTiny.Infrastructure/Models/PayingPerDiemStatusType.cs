using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PayingPerDiemStatusType
{
    public string PayingPerDiemStatusCode { get; set; } = null!;

    public string PayingPerDiemStatusDesc { get; set; } = null!;

    public virtual ICollection<Pjempassign> Pjempassigns { get; set; } = new List<Pjempassign>();
}
