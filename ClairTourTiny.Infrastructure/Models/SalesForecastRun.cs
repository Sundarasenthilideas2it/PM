using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SalesForecastRun
{
    public string UserName { get; set; } = null!;

    public DateTime LastRun { get; set; }

    public int RunCount { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Warehouse { get; set; } = null!;

    public string Billingcompany { get; set; } = null!;

    public string Acctmgr { get; set; } = null!;

    public string SalesForecastGroup { get; set; } = null!;

    public bool SuppressCompanies { get; set; }

    public string ProjectStatusList { get; set; } = null!;

    public string Acctexec { get; set; } = null!;

    public string ProposalTypesList { get; set; } = null!;
}
