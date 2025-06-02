using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectsCurrentlyHavingAvailabilityCalcuated
{
    public string Entityno { get; set; } = null!;

    public DateTime LastTimeEquipmentOrProjectUpdatedUtc { get; set; }
}
