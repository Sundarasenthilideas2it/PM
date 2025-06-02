using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectClientContact
{
    public string Entityno { get; set; } = null!;

    public int IdContactCategory { get; set; }

    public string ContactNo { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
