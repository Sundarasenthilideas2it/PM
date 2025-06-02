using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectsExceedingInsuranceThresholdAlreadyReported
{
    public string Entityno { get; set; } = null!;

    public DateTime ReportDateUtc { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
