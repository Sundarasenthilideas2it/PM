using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectsHistoryConflict20230120
{
    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public string Custno { get; set; } = null!;

    public string Subno { get; set; } = null!;

    public string Shipno { get; set; } = null!;

    public string? BillingCompany { get; set; }

    public string Agency { get; set; } = null!;

    public string InternalOrg { get; set; } = null!;

    public string Industry { get; set; } = null!;

    public string Engactivecd { get; set; } = null!;

    public string Finactivecd { get; set; } = null!;

    public string? Respempno { get; set; }

    public DateTime Propduedate { get; set; }

    public string Proptype { get; set; } = null!;

    public string Plactivecd { get; set; } = null!;

    public string Sfactivecd { get; set; } = null!;

    public string? Opsmgr { get; set; }

    public double? Bidmarkup { get; set; }

    public DateTime ValidFromUtc { get; set; }

    public DateTime? ValidToUtc { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? RemovedBy { get; set; }

    public string? Currency { get; set; }

    public DateTime? ExchangeRateDate { get; set; }

    public DateTime? LoadOut { get; set; }

    public DateTime? CrewPrep { get; set; }

    public DateTime? FirstShow { get; set; }

    public DateTime? LastShow { get; set; }

    public string? EngrEmpno { get; set; }

    public string? AcctExecEmpno { get; set; }

    public bool? PayingPerDiem { get; set; }

    public byte? ReferralProgramId { get; set; }

    public string? Rfplempno { get; set; }
}
