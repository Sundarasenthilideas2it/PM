using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UserWarehouseGroup
{
    public string UserName { get; set; } = null!;

    public string WarehouseGroup { get; set; } = null!;

    public virtual Pjtfrusr UserNameNavigation { get; set; } = null!;

    public virtual ICollection<UserWarehouseGroupsWarehouse> UserWarehouseGroupsWarehouses { get; set; } = new List<UserWarehouseGroupsWarehouse>();
}
