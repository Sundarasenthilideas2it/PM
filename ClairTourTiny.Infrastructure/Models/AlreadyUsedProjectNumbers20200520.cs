using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AlreadyUsedProjectNumbers20200520
{
    public string ServerName { get; set; } = null!;

    public int ProjectNumber { get; set; }

    public int? OwningSessionId { get; set; }

    public string? Entityno { get; set; }
}
