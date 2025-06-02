using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartsOutCountByProject
{
    public string Entitydesc { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public double? TotalOut { get; set; }

    public double? TotalBarcodedOut { get; set; }

    public double? TotalNotBarcodedOut { get; set; }
}
