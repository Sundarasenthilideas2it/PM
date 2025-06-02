using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TransferToolsPhase
{
    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public string Agency { get; set; } = null!;

    public string? Operationsmanager { get; set; }
}
