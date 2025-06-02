using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsprojectImport
{
    public string? Entityno { get; set; }

    public string? Entitydesc { get; set; }

    public DateTime Pstartdate { get; set; }

    public DateTime Penddate { get; set; }

    public string Custno { get; set; } = null!;

    public string Subno { get; set; } = null!;

    public string Shipno { get; set; } = null!;

    public string Agency { get; set; } = null!;

    public string Subcontract { get; set; } = null!;

    public string InternalOrg { get; set; } = null!;

    public string Industry { get; set; } = null!;

    public string Engactivecd { get; set; } = null!;

    public string Finactivecd { get; set; } = null!;

    public int? Respempno { get; set; }

    public string Entitytype { get; set; } = null!;

    public int Prob { get; set; }

    public string Propduedate { get; set; } = null!;

    public string Proptype { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Plactivecd { get; set; } = null!;

    public string Sfactivecd { get; set; } = null!;

    public int? Opsmgr { get; set; }

    public decimal Bidmarkup { get; set; }

    public string? Locationcd { get; set; }

    public string BillingCompany { get; set; } = null!;

    public int? DefaultTaxGroup { get; set; }

    public string? Bidroot { get; set; }

    public string Currency { get; set; } = null!;

    public DateTime ExchangeRateDate { get; set; }

    public int Readytopack { get; set; }

    public int? EngrEmpno { get; set; }

    public int? AcctExecEmpno { get; set; }

    public long? Opportunityiid { get; set; }

    public long? Createdbyempiid { get; set; }

    public DateTime? Createddate { get; set; }

    public long? Modifiedbyempiid { get; set; }

    public DateTime? Modifieddate { get; set; }

    public string? Opportunityname { get; set; }

    public DateTime? Opportunityclosedate { get; set; }

    public long? Opportunitystage { get; set; }

    public long? Opportunitytype { get; set; }

    public long? Opportunityvalue { get; set; }

    public long? Opportunitymargin { get; set; }

    public long? Probability { get; set; }

    public long? Leadsource { get; set; }

    public string? Isactive { get; set; }

    public string? Projectid { get; set; }

    public string? Opportunityid { get; set; }

    public long? Companyiid { get; set; }

    public long? Contactiid { get; set; }

    public long? Siteiid { get; set; }

    public long? Eventiid { get; set; }

    public long? Eventlociid { get; set; }

    public long? Reasoncode { get; set; }

    public string? Opportunitydescription { get; set; }

    public long? Salespersoniid1 { get; set; }

    public long? Ownerempiid { get; set; }

    public long? Salespersoniid2 { get; set; }

    public long? Salespersoniid3 { get; set; }

    public DateTime? Stagedate { get; set; }

    public long? Transactioncurrencyiid { get; set; }

    public long? Sitecurrencyiid { get; set; }

    public long? Basecurrencyiid { get; set; }

    public long? Totalvaluecurrencyiid { get; set; }

    public string? Reasoncomments { get; set; }

    public short? Status { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? Actualdate { get; set; }

    public string? Synchronizer2 { get; set; }
}
