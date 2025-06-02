using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdscontractsWithoutEventsOrProjectsImport
{
    public string? Entityno { get; set; }

    public string? Entitydesc { get; set; }

    public DateTime? StartdateF { get; set; }

    public DateTime? EnddateF { get; set; }

    public string Custno { get; set; } = null!;

    public string Subno { get; set; } = null!;

    public string Shipno { get; set; } = null!;

    public string? Agency { get; set; }

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

    public string? Currency { get; set; }

    public DateTime ExchangeRateDate { get; set; }

    public int Readytopack { get; set; }

    public int? EngrEmpno { get; set; }

    public int? AcctExecEmpno { get; set; }

    public string? Parententityno { get; set; }

    public string? Parententitydesc { get; set; }

    public long? Contractiid { get; set; }

    public string? Contractid { get; set; }

    public string? Contractdescription { get; set; }

    public DateTime? Datecreated { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public long? Contactiid { get; set; }

    public long? Billingaddressiid { get; set; }

    public long? Shippingaddressiid { get; set; }

    public short? Type { get; set; }

    public string? Department { get; set; }

    public long? Periodiid { get; set; }

    public long? Pricingiid { get; set; }

    public long? Billingtermiid { get; set; }

    public long? Paymenttermsiid { get; set; }

    public DateTime? Nextinvoicedate { get; set; }

    public long? Employeeiid { get; set; }

    public long? Salespersoniid { get; set; }

    public long? Stationiid { get; set; }

    public long? Siteiid { get; set; }

    public long? Currencyiid { get; set; }

    public double? Totalitemsamount { get; set; }

    public double? Totalitemstaxamount { get; set; }

    public double? Totalitemsdiscount { get; set; }

    public short? Revision { get; set; }

    public long? Quoteiid { get; set; }

    public int? Comments { get; set; }

    public long? Eventiid { get; set; }

    public long? Evenlociid { get; set; }

    public string? Boothroomno { get; set; }

    public long? Ponumber { get; set; }

    public double? Totallaboramount { get; set; }

    public double? Totallabortaxamount { get; set; }

    public double? Totallabordiscount { get; set; }

    public short? Status { get; set; }

    public double? Deposit { get; set; }

    public double? Advance { get; set; }

    public short? Shipcarriertype { get; set; }

    public DateTime? Shipdate { get; set; }

    public short? Lockcount { get; set; }

    public string? Shippinglocation { get; set; }

    public short? Mop { get; set; }

    public short? Payhow { get; set; }

    public double? Daysinweek { get; set; }

    public string? Disclaimerid { get; set; }

    public DateTime? Revisiondate { get; set; }

    public string? Location { get; set; }

    public string? Taxcertno { get; set; }

    public DateTime? Datevalidtill { get; set; }

    public double? Rushcharges { get; set; }

    public double? Deliverycharges { get; set; }

    public double? Expenses { get; set; }

    public double? Freightcharges { get; set; }

    public double? Dummy1 { get; set; }

    public string? Disclaimer { get; set; }

    public double? Insurancepercent { get; set; }

    public double? Insuranceamount { get; set; }

    public short? Warehousestatus { get; set; }

    public short? Warehousedept { get; set; }

    public string? Customertaxgroup { get; set; }

    public string? Inuseby { get; set; }

    public string? Taxlabor { get; set; }

    public string? Profitcentre { get; set; }

    public long? Billingcustomeriid { get; set; }

    public long? Shippingcustomeriid { get; set; }

    public string? Commissiongroup { get; set; }

    public long? Billingcontactiid { get; set; }

    public string? Custdiscountgroup { get; set; }

    public double? Orderdiscount { get; set; }

    public short? Damagewaivertype { get; set; }

    public double? Damagewaivervalue { get; set; }

    public short? Defaultunit { get; set; }

    public long? Jobiid { get; set; }

    public long? Parentcontractiid { get; set; }

    public short? Servicechargetype { get; set; }

    public double? Servicechargevalue { get; set; }

    public DateTime? Lastupdated { get; set; }

    public string? Miscmargin { get; set; }

    public string? Uccontractdescription { get; set; }

    public DateTime? Lastprinteddate { get; set; }

    public string? Useeventpricing { get; set; }

    public short? Priority { get; set; }

    public string? Trackingno { get; set; }

    public string? Isworkorder { get; set; }

    public double? Dwtaxamount { get; set; }

    public long? Createdby { get; set; }

    public int? Probability { get; set; }

    public double? Servicechargetaxamount { get; set; }

    public short? Saleorder { get; set; }

    public double? Flatprice { get; set; }

    public long? Returncontactiid { get; set; }

    public string? Shippingcontactname { get; set; }

    public string? Returncontactname { get; set; }

    public short? Returncarriertype { get; set; }

    public long? Returnaddressiid { get; set; }

    public string? Returnboothroomno { get; set; }

    public string? Returntrackingno { get; set; }

    public string? Returnlocation { get; set; }

    public string? Istaxable { get; set; }

    public string? Periodicscheduletype { get; set; }

    public short? Preorposttax { get; set; }

    public string? Stopbillingflag { get; set; }

    public DateTime? Stopbillingdate { get; set; }

    public string? Project { get; set; }

    public string? Ismasterbilling { get; set; }

    public long? Masterbillingiid { get; set; }

    public string? Customerpricegroupid { get; set; }

    public short? Paytype { get; set; }

    public short? Returnconfirmed { get; set; }

    public long? Functioniid { get; set; }

    public short? Category { get; set; }

    public short? Approvalrequired { get; set; }

    public string? Paymethodreference { get; set; }

    public double? Damagewaiverpercent { get; set; }

    public double? Servicechargepercent { get; set; }

    public string? Scondiscountedamount { get; set; }

    public string? Servicechargeonsellitems { get; set; }

    public double? Daysinmonth { get; set; }

    public string? Viewfirstinvoice { get; set; }

    public string? Signoffstatus { get; set; }

    public string? Laborpricegroupid { get; set; }

    public string? Applytaxonservicecharge { get; set; }

    public string? Applytaxondamagewaiver { get; set; }

    public string? Shippingboothroomno { get; set; }

    public string? Defaultmainorderinfotosuborder { get; set; }

    public string? Ordercategory { get; set; }

    public string? Ordersubcategory { get; set; }

    public short? Consumabletype { get; set; }

    public double? Consumablevalue { get; set; }

    public double? Consumablepercent { get; set; }

    public string? Applytaxonconsumable { get; set; }

    public double? Cmtaxamount { get; set; }

    public long? Basecurrencyiid { get; set; }

    public long? Sitecurrencyiid { get; set; }

    public long? Transactioncurrencyiid { get; set; }

    public string? Roundtoid { get; set; }

    public string? Pickupbycustomer { get; set; }

    public string? Returnbycustomer { get; set; }

    public DateTime? Converteddate { get; set; }

    public short? Discounttype { get; set; }

    public double? Discountamount { get; set; }

    public string? Notificationflag { get; set; }

    public string? Isautoreceiveship { get; set; }

    public string? Isicsorder { get; set; }

    public long? Planneriid { get; set; }

    public string? Isforcedclosed { get; set; }

    public double? Totaltaxamount { get; set; }

    public string? Applyflatprice { get; set; }

    public DateTime? Lastupdateddbdate { get; set; }

    public string? Languageid { get; set; }

    public double? Approveddiscountperc { get; set; }

    public DateTime? Chargestartdate { get; set; }

    public DateTime? Chargeenddate { get; set; }

    public DateTime? Prepdate { get; set; }

    public DateTime? Loadindate { get; set; }

    public DateTime? Rehearsaldate { get; set; }

    public DateTime? Showstartdate { get; set; }

    public DateTime? Showenddate { get; set; }

    public DateTime? Strikedate { get; set; }

    public DateTime? Pickupdate { get; set; }

    public DateTime? Returndate { get; set; }

    public short? Credithold { get; set; }

    public double? Overheadrate { get; set; }

    public double? Totalorderfulldurationamt { get; set; }

    public double? Totalorderfulldurationtax { get; set; }

    public double? Firstinvoiceamount { get; set; }

    public long? Pricingruleiid { get; set; }

    public long? Accountsgroupiid { get; set; }

    public string? Readyforoperations { get; set; }

    public double? Burdenpercentage { get; set; }

    public string? VersionRemarks { get; set; }

    public short? Ordersubtype { get; set; }

    public short? Customstatus { get; set; }

    public short? Userdefinedstatus { get; set; }

    public string? ChargebasedDayweekmonthprice { get; set; }
}
