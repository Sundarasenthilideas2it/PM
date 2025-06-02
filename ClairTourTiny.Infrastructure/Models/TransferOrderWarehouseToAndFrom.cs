using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TransferOrderWarehouseToAndFrom
{
    public string FromWarehouseCode { get; set; } = null!;

    public string ToWarehouseCode { get; set; } = null!;

    public bool OnCalendar { get; set; }

    public bool Active { get; set; }

    public virtual Warehouse FromWarehouseCodeNavigation { get; set; } = null!;

    public virtual Warehouse ToWarehouseCodeNavigation { get; set; } = null!;
}
