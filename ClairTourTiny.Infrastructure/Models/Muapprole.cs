using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Muapprole
{
    public string EssSecurityAccount { get; set; } = null!;

    public string EssSecurityPassword { get; set; } = null!;

    public Guid Rowguid { get; set; }
}
