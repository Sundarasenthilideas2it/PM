using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartSubhireNote
{
    public string Partno { get; set; } = null!;

    public string SubhireNotes { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;
}
