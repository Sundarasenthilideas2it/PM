using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ReferenceSet
{
    public int ReferenceSetId { get; set; }

    public string Cabinet { get; set; } = null!;

    public string? Configuration { get; set; }

    public string? Component { get; set; }

    public string Test { get; set; } = null!;

    public string Partno { get; set; } = null!;
}
