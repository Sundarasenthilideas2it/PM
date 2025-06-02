using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UseLogger
{
    public string Name { get; set; } = null!;

    public int UseCount { get; set; }

    public DateTime? LastAccess { get; set; }

    public string? LastAccessBy { get; set; }

    public DateTime? PreviousLastAccess { get; set; }

    public string? PreviousLastAccessBy { get; set; }

    public DateTime? LoggingStartDate { get; set; }
}
