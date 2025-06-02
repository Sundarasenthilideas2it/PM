using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RepairActivitiesRequisition
{
    public int IdActivity { get; set; }

    public string ReqNo { get; set; } = null!;

    public int LineNo { get; set; }
}
