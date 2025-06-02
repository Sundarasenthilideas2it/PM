using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class WarehouseHoliday
{
    public string WarehouseCode { get; set; } = null!;

    public DateOnly Date { get; set; }

    public virtual Warehouse WarehouseCodeNavigation { get; set; } = null!;
}
