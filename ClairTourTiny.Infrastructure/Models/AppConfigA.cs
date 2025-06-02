using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AppConfigA
{
    public string Cmndsel { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public object? Value { get; set; }

    public DateTime AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
