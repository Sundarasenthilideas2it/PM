using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RiggingInspectionLocation
{
    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public int? Qty { get; set; }

    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;
}
