using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Popayterm
{
    public string Paytermscd { get; set; } = null!;

    public string Paytermsdesc { get; set; } = null!;

    public string EomInd { get; set; } = null!;

    public int DiscDays { get; set; }

    public string DiscFxpc { get; set; } = null!;

    public double DiscRate { get; set; }

    public int NetDays { get; set; }

    public bool ShowPrepaidWarningOnNewVouchers { get; set; }

    public virtual ICollection<PurchaseOrder1> PurchaseOrders { get; set; } = new List<PurchaseOrder1>();
}
