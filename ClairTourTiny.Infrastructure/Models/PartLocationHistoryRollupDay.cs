using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartLocationHistoryRollupDay
{
    public DateTime Date { get; set; }

    public bool IsIndexed { get; set; }
}
