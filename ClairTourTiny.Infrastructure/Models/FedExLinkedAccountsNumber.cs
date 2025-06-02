using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FedExLinkedAccountsNumber
{
    public string LinkedAccountCode { get; set; } = null!;

    public string MasterAccountCode { get; set; } = null!;

    public string? LocalAccountCode { get; set; }

    public string CompanyCode { get; set; } = null!;

    public virtual Company CompanyCodeNavigation { get; set; } = null!;
}
