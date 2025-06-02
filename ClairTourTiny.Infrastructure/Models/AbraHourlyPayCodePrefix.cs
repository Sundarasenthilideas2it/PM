using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AbraHourlyPayCodePrefix
{
    public string Prefix { get; set; } = null!;

    public virtual ICollection<Pejob> Pejobs { get; set; } = new List<Pejob>();
}
