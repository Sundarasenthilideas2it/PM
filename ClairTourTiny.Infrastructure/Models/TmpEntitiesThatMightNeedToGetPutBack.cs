using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEntitiesThatMightNeedToGetPutBack
{
    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public string Custno { get; set; } = null!;

    public string Subno { get; set; } = null!;

    public string Shipno { get; set; } = null!;

    public string Agency { get; set; } = null!;

    public string Subcontract { get; set; } = null!;

    public string InternalOrg { get; set; } = null!;

    public string? Industry { get; set; }

    public string Engactivecd { get; set; } = null!;

    public string Finactivecd { get; set; } = null!;

    public string? Respempno { get; set; }

    public string Entitytype { get; set; } = null!;

    public int Probability { get; set; }

    public DateTime Propduedate { get; set; }

    public string? Proptype { get; set; }

    public string Country { get; set; } = null!;

    public string Plactivecd { get; set; } = null!;

    public string Sfactivecd { get; set; } = null!;

    public string? Opsmgr { get; set; }

    public double? Bidmarkup { get; set; }

    public string? Locationcd { get; set; }

    public string? BillingCompany { get; set; }

    public int? DefaultTaxGroup { get; set; }

    public string? Bidroot { get; set; }

    public string? Currency { get; set; }

    public DateTime? ExchangeRateDate { get; set; }

    public DateTime? LoadOut { get; set; }

    public DateTime? CrewPrep { get; set; }

    public DateTime? FirstShow { get; set; }

    public DateTime? LastShow { get; set; }

    public short Readytopack { get; set; }

    public string? EngrEmpno { get; set; }

    public string? AcctExecEmpno { get; set; }

    public bool? PayingPerDiem { get; set; }

    public string? RootEntityno { get; set; }

    public byte? ReferralProgramId { get; set; }

    public bool? TruckingConfirmed { get; set; }

    public string? TruckingVendNo { get; set; }

    public string? Rfplempno { get; set; }

    public int? PollstarArtistId { get; set; }

    public string? CrmleadUrl { get; set; }

    public Guid Guid { get; set; }

    public double? PriceLevelValue { get; set; }

    public string? TaxTypeKey { get; set; }

    public string? OeOrderno { get; set; }

    public string? LeadTime { get; set; }

    public string? Matrixcd { get; set; }

    public string? TaxCode { get; set; }
}
