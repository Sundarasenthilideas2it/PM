using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UnifiedContactBrokerExecutionLog
{
    public DateTime ExecutionDate { get; set; }

    public string RequestType { get; set; } = null!;

    public string? ExecutionRequest { get; set; }
}
