using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPlus4ProjectsMapping
{
    public string Entityno { get; set; } = null!;

    public string RootEntityno { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string RootId { get; set; } = null!;

    public string? LegEntityno { get; set; }

    public string? P4phaseType { get; set; }
}
