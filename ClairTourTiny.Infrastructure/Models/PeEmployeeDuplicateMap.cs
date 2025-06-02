using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeEmployeeDuplicateMap
{
    public string OldEmpno { get; set; } = null!;

    public string? NewEmpno { get; set; }

    public virtual Peemployee? NewEmpnoNavigation { get; set; }

    public virtual Peemployee OldEmpnoNavigation { get; set; } = null!;
}
