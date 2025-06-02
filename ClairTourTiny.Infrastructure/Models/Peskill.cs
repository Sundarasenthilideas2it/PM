using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Peskill
{
    public string Skill { get; set; } = null!;

    public string Skilldesc { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
