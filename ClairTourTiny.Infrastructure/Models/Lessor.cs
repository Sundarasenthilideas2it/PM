using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Lessor
{
    public string LessorCode { get; set; } = null!;

    public string LessorName { get; set; } = null!;

    public virtual ICollection<Inpartsub> Inpartsubs { get; set; } = new List<Inpartsub>();
}
