using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UsedEquipmentSalesRevenueAccount
{
    public string Acctcd { get; set; } = null!;

    public virtual Glaccount AcctcdNavigation { get; set; } = null!;
}
