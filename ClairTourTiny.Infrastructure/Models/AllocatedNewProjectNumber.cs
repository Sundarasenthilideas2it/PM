using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllocatedNewProjectNumber
{
    public string ServerName { get; set; } = null!;

    public int ProjectNumber { get; set; }

    public int? OwningSessionId { get; set; }
}
