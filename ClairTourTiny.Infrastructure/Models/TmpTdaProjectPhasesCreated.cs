using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaProjectPhasesCreated
{
    public string? Entityno { get; set; }

    public string? Entitydesc { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string Agency { get; set; } = null!;

    public string InternalOrg { get; set; } = null!;

    public string? JobEngActiveCd { get; set; }

    public string Finactivecd { get; set; } = null!;

    public string? Respempno { get; set; }

    public string Entitytype { get; set; } = null!;

    public string Probability { get; set; } = null!;

    public string? Proptype { get; set; }

    public string Plactive { get; set; } = null!;

    public string Sfactivecd { get; set; } = null!;

    public string? Opsmgr { get; set; }

    public double? BidFactor { get; set; }

    public string BillingCompany { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public DateTime? ExchangeRateDate { get; set; }

    public string LoadOut { get; set; } = null!;

    public string CrewPrep { get; set; } = null!;

    public string FirstShow { get; set; } = null!;

    public string LastShow { get; set; } = null!;

    public int? SecondaryOpsEmpno { get; set; }

    public int IdProject { get; set; }

    public string? ProjNumber { get; set; }

    public string? ProjectStatusCode { get; set; }

    public string ProjType { get; set; } = null!;

    public decimal? ProjRentalSumPrice { get; set; }

    public int? ProjectArranger { get; set; }

    public string? FinesseUser { get; set; }

    public DateTime? DayTimeOut { get; set; }

    public DateTime? DayTimeIn { get; set; }
}
