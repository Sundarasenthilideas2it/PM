using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class JobBudgetsPartsTransactionsNeedingRefresh
{
    public DateTime DateAdded { get; set; }

    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;
}
