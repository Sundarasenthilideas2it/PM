using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecTempProjectAccountBalance
{
    public string Entityno { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Acctcd { get; set; } = null!;

    public string RevRecType { get; set; } = null!;

    public double CreditAmount { get; set; }

    public double DebitAmount { get; set; }

    public virtual Glaccount AcctcdNavigation { get; set; } = null!;

    public virtual RevRecCategory CategoryNavigation { get; set; } = null!;

    public virtual Company CompanyCodeNavigation { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
