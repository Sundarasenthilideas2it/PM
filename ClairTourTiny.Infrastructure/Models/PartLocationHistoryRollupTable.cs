using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartLocationHistoryRollupTable
{
    public string Bld { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public DateOnly Date { get; set; }

    public double InstockDollars { get; set; }

    public double RepairDollars { get; set; }

    public double TransferringDollars { get; set; }

    public double UtilizedDollars { get; set; }
}
