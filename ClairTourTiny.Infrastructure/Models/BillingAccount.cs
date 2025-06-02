using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BillingAccount
{
    public string Companyno { get; set; } = null!;

    public string Acctcd { get; set; } = null!;

    public string FriendlyName { get; set; } = null!;

    public bool Visible { get; set; }

    public bool UseShowDatesInsteadOfRfidatesForRevrec { get; set; }

    public bool IsLabor { get; set; }

    public bool IsEquipment { get; set; }

    public bool IsExpense { get; set; }

    public bool IsPerDiem { get; set; }

    public string? Expcd { get; set; }

    public bool IsEquipmentSale { get; set; }

    public string? IfsinterCompanyCode { get; set; }

    public virtual Glaccount AcctcdNavigation { get; set; } = null!;

    public virtual Company CompanynoNavigation { get; set; } = null!;

    public virtual Apexpcode? ExpcdNavigation { get; set; }
}
