using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IfspaymentTerm
{
    public string IfstermsCode { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Oepayterm> Paytermscds { get; set; } = new List<Oepayterm>();
}
