using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeemVisibleDivision
{
    public string Userid { get; set; } = null!;

    public string Division { get; set; } = null!;

    public bool CanSeePayRate { get; set; }

    public bool CanEditPayRate { get; set; }

    public bool CanEditEmployee { get; set; }

    public virtual Pedivision DivisionNavigation { get; set; } = null!;
}
