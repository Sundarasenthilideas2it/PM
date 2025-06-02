using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ISolvedEmail
{
    public int ISolvedId { get; set; }

    public string EmailAddress { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public virtual ISolvedContact ISolved { get; set; } = null!;
}
