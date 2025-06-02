using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartTagIdea
{
    public string Partno { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
