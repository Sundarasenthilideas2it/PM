using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UserWarehouseGroupsWarehouse
{
    public string UserName { get; set; } = null!;

    public string WarehouseGroup { get; set; } = null!;

    public string WarehouseCode { get; set; } = null!;

    public virtual Pjtfrusr UserNameNavigation { get; set; } = null!;

    public virtual UserWarehouseGroup UserWarehouseGroup { get; set; } = null!;

    public virtual Warehouse WarehouseCodeNavigation { get; set; } = null!;
}
