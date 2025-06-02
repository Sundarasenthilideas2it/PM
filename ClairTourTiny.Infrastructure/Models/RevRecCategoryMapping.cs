using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecCategoryMapping
{
    public string Category { get; set; } = null!;

    public double DebitMultiplier { get; set; }

    public double CreditMultiplier { get; set; }

    public string Acctcd { get; set; } = null!;

    public string? RevRecType { get; set; }

    public bool UseRfiaccount { get; set; }

    public string Billingcompany { get; set; } = null!;

    public virtual Glaccount AcctcdNavigation { get; set; } = null!;

    public virtual Company BillingcompanyNavigation { get; set; } = null!;

    public virtual RevRecCategory CategoryNavigation { get; set; } = null!;
}
