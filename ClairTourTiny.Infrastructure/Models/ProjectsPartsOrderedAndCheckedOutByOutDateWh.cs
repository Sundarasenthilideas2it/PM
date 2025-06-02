using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectsPartsOrderedAndCheckedOutByOutDateWh
{
    public string? Warehouse { get; set; }

    public DateTime Trandate { get; set; }

    public string Entityno { get; set; } = null!;

    public int? PartsOrdered { get; set; }

    public int? PartsCheckedOut { get; set; }

    public long? EquipmentRowCount { get; set; }
}
