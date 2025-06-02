using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ISolvedPhone
{
    public int ISolvedId { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public virtual ISolvedContact ISolved { get; set; } = null!;
}
