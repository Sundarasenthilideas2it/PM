using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TaxAccount
{
    public string Companyno { get; set; } = null!;

    public string Acctcd { get; set; } = null!;

    public bool Visible { get; set; }

    public int FriendlyNameId { get; set; }

    public string? SysproTaxCode { get; set; }

    public virtual Glaccount AcctcdNavigation { get; set; } = null!;

    public virtual Company CompanynoNavigation { get; set; } = null!;

    public virtual AccountFriendlyName FriendlyName { get; set; } = null!;
}
