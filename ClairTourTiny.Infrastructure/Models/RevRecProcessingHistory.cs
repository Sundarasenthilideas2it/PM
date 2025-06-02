using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecProcessingHistory
{
    public DateTime ProcessingDate { get; set; }

    public DateTime Cutoffdate { get; set; }

    public string RunBy { get; set; } = null!;
}
