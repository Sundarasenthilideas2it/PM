using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RfiInProcessSplitSummary
{
    public string Entityno { get; set; } = null!;

    public int? InvoicesProcessed { get; set; }

    public int? InProcess { get; set; }

    public long? CBig { get; set; }
}
