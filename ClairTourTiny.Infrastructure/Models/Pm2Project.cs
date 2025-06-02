using System.ComponentModel.DataAnnotations.Schema;
namespace ClairTourTiny.Infrastructure.Models;

public class Pm2Project
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string EntitynoOld { get; set; } = null!;

    public string EntitynoNew { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Custno { get; set; }

    public string? Subno { get; set; }

    public string? Shipno { get; set; }

    public string? BillingCompany { get; set; }

    public string? Agency { get; set; }

    public string? InternalOrg { get; set; }

    public string? Industry { get; set; }

    public string? Engactivecd { get; set; }

    public string? Finactivecd { get; set; }

    public string? Respempno { get; set; }

    public DateTime? Propduedate { get; set; }

    public string? Proptype { get; set; }

    public string? Plactivecd { get; set; }

    public string? Sfactivecd { get; set; }

    public string? Opsmgr { get; set; }

    public double? Bidmarkup { get; set; }

    public int? Probability { get; set; }

    public string? Currency { get; set; }

    public DateOnly? ExchangeRateDate { get; set; }

    public DateTime? LoadOut { get; set; }

    public DateTime? CrewPrep { get; set; }

    public DateTime? FirstShow { get; set; }

    public DateTime? LastShow { get; set; }

    public string? EngrEmpno { get; set; }

    public string? AcctExecEmpno { get; set; }

    public bool? PayingPerDiem { get; set; }

    public byte? ReferralProgramId { get; set; }

    public bool? TruckingConfirmed { get; set; }

    public string? TruckingVendNo { get; set; }

    public string? Rfplempno { get; set; }

    public int? PollstarArtistId { get; set; }

    public string? CrmleadUrl { get; set; }

    public Guid? Guid { get; set; }

    public double? PriceLevelValue { get; set; }

    public string? TaxTypeKey { get; set; }

    public string? OeOrderno { get; set; }

    public string? LeadTime { get; set; }

    public string? Matrixcd { get; set; }

    public string? TaxCode { get; set; }

    public string? CrewOpsEmpno { get; set; }

    public string? SecondaryOpsEmpno { get; set; }

    public string? Note { get; set; }

    public string? SecondaryCrewOpsEmpno { get; set; }
    [NotMapped]
    public List<Pm2Crew> Crews { get; set; } = new List<Pm2Crew>();
    [NotMapped]
    public List<Pm2Rfi> RFI { get; set; } = new List<Pm2Rfi>(); 
    [NotMapped]
    public List<Pm2Equipment> Equipment { get; set; } = new List<Pm2Equipment>();
}
