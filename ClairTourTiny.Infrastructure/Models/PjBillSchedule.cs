using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PjBillSchedule
{
    public string Billschedule { get; set; } = null!;

    public string ScheduleName { get; set; } = null!;

    public virtual ICollection<InvoiceSeries> InvoiceSeries { get; set; } = new List<InvoiceSeries>();

    public virtual ICollection<Pjproptype> Pjproptypes { get; set; } = new List<Pjproptype>();

    public virtual ICollection<Rfi> Rfis { get; set; } = new List<Rfi>();
}
