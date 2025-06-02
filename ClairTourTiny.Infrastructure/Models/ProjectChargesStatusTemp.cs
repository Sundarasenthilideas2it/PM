using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectChargesStatusTemp
{
    public string Entityno { get; set; } = null!;

    public int? Unapproved { get; set; }

    public int? Unassigned { get; set; }

    public DateTime? MinInProcessChargeStartDate { get; set; }

    public DateTime? MinUnassignedChargeStartDate { get; set; }

    public int? InProcess { get; set; }

    public int? TotalCompleted { get; set; }

    public int? Total { get; set; }
}
