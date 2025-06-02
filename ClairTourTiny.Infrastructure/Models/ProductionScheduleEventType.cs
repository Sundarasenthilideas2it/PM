using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProductionScheduleEventType
{
    public string TypeCode { get; set; } = null!;

    public string TypeDescription { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public bool IsCalProjNote { get; set; }

    public bool IsIncoming { get; set; }

    public bool IsCalGenericNote { get; set; }

    public string ShortDesc { get; set; } = null!;

    public bool IsFirstLoadIn { get; set; }

    public bool IsLastLoadOut { get; set; }

    public bool IsTrucking { get; set; }

    public virtual ICollection<ProjectProductionSchedule> ProjectProductionSchedules { get; set; } = new List<ProjectProductionSchedule>();
}
