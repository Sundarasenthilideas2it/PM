using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdseventsWithoutProjectsImport
{
    public int? Parententityno { get; set; }

    public string? Entityno { get; set; }

    public string? Entitydesc { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

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

    public long? Eventiid { get; set; }

    public string? Eventname { get; set; }

    public long? Customeriid { get; set; }

    public DateTime? Starteventdate { get; set; }

    public DateTime? Endeventdate { get; set; }

    public long? Commissioniid { get; set; }

    public long? Pricegroup { get; set; }

    public short? Type { get; set; }

    public short? Disctype { get; set; }

    public double? Discamount { get; set; }

    public string? Eventid { get; set; }

    public string? Profitcenter { get; set; }

    public string? Referenceno { get; set; }

    public DateTime? Datecreated { get; set; }

    public short? Status { get; set; }

    public short? Eventtype { get; set; }

    public long? Salespersoniid { get; set; }

    public long? Eventmanageriid { get; set; }

    public long? Maincontactiid { get; set; }

    public string? Isclosed { get; set; }

    public short? Approvalrequired { get; set; }

    public short? Category { get; set; }

    public string? Projectid { get; set; }

    public long? Laborpricegroup { get; set; }

    public long? Projectmanageriid { get; set; }

    public long? Createdby { get; set; }
}
