using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectsPartsOrderedAndCheckedOutByInDateWh
{
    public string? Warehouse { get; set; }

    public DateTime Todate { get; set; }

    public string Entityno { get; set; } = null!;

    public int? PartsOrdered { get; set; }

    public int? PartsCheckedOut { get; set; }

    public long? EquipmentRowCount { get; set; }
}
