using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpRockfishPart
{
    public int? PartId { get; set; }

    public string Category { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int Qty { get; set; }

    public string? Partno { get; set; }

    public string? CheckedBy { get; set; }

    public DateTimeOffset? CheckedDate { get; set; }

    public string? CheckComment { get; set; }
}
