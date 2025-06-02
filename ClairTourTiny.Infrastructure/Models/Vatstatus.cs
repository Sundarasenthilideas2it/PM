using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Vatstatus
{
    public string StatusCode { get; set; } = null!;

    public string StatusDesc { get; set; } = null!;

    public string? DefaultTaxTypeKey { get; set; }

    public virtual ICollection<OecustbillOld> OecustbillOlds { get; set; } = new List<OecustbillOld>();

    public virtual ICollection<Povendsite> Povendsites { get; set; } = new List<Povendsite>();
}
