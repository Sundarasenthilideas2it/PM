using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AbraHourlyPayCode
{
    public string Code { get; set; } = null!;

    public virtual ICollection<Pejob> Pejobs { get; set; } = new List<Pejob>();
}
