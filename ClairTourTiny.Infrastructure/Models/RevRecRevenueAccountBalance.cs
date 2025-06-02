using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecRevenueAccountBalance
{
    public string Entityno { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Acctcd { get; set; } = null!;

    public double CreditNewAmount { get; set; }

    public double CreditOldAmount { get; set; }

    public double CreditAmountDiff { get; set; }

    public double DebitNewAmount { get; set; }

    public double DebitOldAmount { get; set; }

    public double DebitAmountDiff { get; set; }

    public virtual Glaccount AcctcdNavigation { get; set; } = null!;

    public virtual RevRecCategory CategoryNavigation { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
