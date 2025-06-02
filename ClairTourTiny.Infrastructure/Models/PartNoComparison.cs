using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartNoComparison
{
    public DateOnly? Date { get; set; }

    public decimal? PartNo1Qty { get; set; }

    public decimal? PartNo2Qty { get; set; }

    public decimal? Ratio { get; set; }
}
