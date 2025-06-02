using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class JobBudgetPartsCheckedOut
{
    public string Batchno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public int? Checkoutqty { get; set; }

    public int? HeldinWarehouse { get; set; }

    public long? CBig { get; set; }
}
