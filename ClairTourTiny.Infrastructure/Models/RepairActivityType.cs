using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RepairActivityType
{
    public string ActivityType { get; set; } = null!;

    public int SortOrder { get; set; }

    public virtual ICollection<RepairActivity> RepairActivities { get; set; } = new List<RepairActivity>();
}
