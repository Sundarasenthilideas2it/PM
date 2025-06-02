using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GlentitiesNonPj
{
    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public int Glstart { get; set; }

    public int Glend { get; set; }

    public int Instart { get; set; }

    public int Inend { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public DateTime Optdate1 { get; set; }

    public DateTime Optdate2 { get; set; }

    public int FloatDays { get; set; }

    public string Custno { get; set; } = null!;

    public string Subno { get; set; } = null!;

    public string Shipno { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Groupno { get; set; } = null!;

    public string Jobord { get; set; } = null!;

    public string Purchord { get; set; } = null!;

    public string Contractno { get; set; } = null!;

    public string Orderno { get; set; } = null!;

    public int Orditemno { get; set; }

    public string Agency { get; set; } = null!;

    public string Subcontract { get; set; } = null!;

    public string Projecttype { get; set; } = null!;

    public int Priority { get; set; }

    public string Classification { get; set; } = null!;

    public string Subclass { get; set; } = null!;

    public string Productclass { get; set; } = null!;

    public string InternalOrg { get; set; } = null!;

    public string? Industry { get; set; }

    public string Engactivecd { get; set; } = null!;

    public string Finactivecd { get; set; } = null!;

    public string Expacctcd { get; set; } = null!;

    public string Labacctcd { get; set; } = null!;

    public string Adjacctcd { get; set; } = null!;

    public string Matacctcd { get; set; } = null!;

    public string Eqpacctcd { get; set; } = null!;

    public double Expmarkup1 { get; set; }

    public double Labmarkup1 { get; set; }

    public double Eqpmarkup1 { get; set; }

    public double Expmarkup2 { get; set; }

    public double Labmarkup2 { get; set; }

    public double Eqpmarkup2 { get; set; }

    public double Expmarkup3 { get; set; }

    public double Labmarkup3 { get; set; }

    public double Eqpmarkup3 { get; set; }

    public double Expmarkup4 { get; set; }

    public double Labmarkup4 { get; set; }

    public double Eqpmarkup4 { get; set; }

    public double Deliverables { get; set; }

    public string Delivertype { get; set; } = null!;

    public string? Respempno { get; set; }

    public string Resplastname { get; set; } = null!;

    public string Respfirstname { get; set; } = null!;

    public string Actempno { get; set; } = null!;

    public string Actlastname { get; set; } = null!;

    public string Actfirstname { get; set; } = null!;

    public double Actualcomplete { get; set; }

    public double Hours1 { get; set; }

    public double Hours2 { get; set; }

    public double Hours3 { get; set; }

    public double Hours4 { get; set; }

    public decimal Dollar1 { get; set; }

    public decimal Dollar2 { get; set; }

    public decimal Dollar3 { get; set; }

    public decimal Dollar4 { get; set; }

    public decimal Maxdol1 { get; set; }

    public decimal Maxdol2 { get; set; }

    public decimal Maxdol3 { get; set; }

    public decimal Maxdol4 { get; set; }

    public string Schedule1 { get; set; } = null!;

    public string Schedule2 { get; set; } = null!;

    public string Schedule3 { get; set; } = null!;

    public string Schedule4 { get; set; } = null!;

    public string Entitytype { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Respcenter { get; set; } = null!;

    public double Feepercent { get; set; }

    public decimal Feefixed { get; set; }

    public decimal Feecap { get; set; }

    public string Reportflag { get; set; } = null!;

    public string Costofmoney { get; set; } = null!;

    public int Probability { get; set; }

    public DateTime Frequency { get; set; }

    public DateTime Propduedate { get; set; }

    public string? Proptype { get; set; }

    public decimal Propprice { get; set; }

    public decimal Propcost { get; set; }

    public string Rfpyn { get; set; } = null!;

    public string Bidyn { get; set; } = null!;

    public string Expmatrixcd { get; set; } = null!;

    public string Labmatrixcd { get; set; } = null!;

    public string Adjmatrixcd { get; set; } = null!;

    public string Matmatrixcd { get; set; } = null!;

    public string Eqpmatrixcd { get; set; } = null!;

    public decimal CogsValue { get; set; }

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public string Ref7 { get; set; } = null!;

    public string Ref8 { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string ExpId { get; set; } = null!;

    public string TrafficId { get; set; } = null!;

    public string BuyerId { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }

    public string Plactivecd { get; set; } = null!;

    public string Sfactivecd { get; set; } = null!;

    public string ContactName { get; set; } = null!;

    public string ContactPhone { get; set; } = null!;

    public string ContactMobile { get; set; } = null!;

    public string ContactEmail { get; set; } = null!;

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
}
