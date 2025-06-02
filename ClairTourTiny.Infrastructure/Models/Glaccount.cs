using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Glaccount
{
    public string Acctcd { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Activecd { get; set; } = null!;

    public string Postcd { get; set; } = null!;

    public string Accttype { get; set; } = null!;

    public string Debitacct { get; set; } = null!;

    public string Debitind { get; set; } = null!;

    public decimal Rangeamt { get; set; }

    public string Reqactivity { get; set; } = null!;

    public double Chgpcnt { get; set; }

    public string Subpost { get; set; } = null!;

    public string Cashflow { get; set; } = null!;

    public string Scode { get; set; } = null!;

    public int Rptseqno { get; set; }

    public decimal Beginbal { get; set; }

    public decimal Endbal { get; set; }

    public decimal OrigBeginbal { get; set; }

    public decimal OrigEndbal { get; set; }

    public decimal Beg1prevyr { get; set; }

    public decimal End1prevyr { get; set; }

    public decimal OrigBeg1prevyr { get; set; }

    public decimal OrigEnd1prevyr { get; set; }

    public decimal Beg2prevyr { get; set; }

    public decimal End2prevyr { get; set; }

    public decimal OrigBeg2prevyr { get; set; }

    public decimal OrigEnd2prevyr { get; set; }

    public decimal Beg3prevyr { get; set; }

    public decimal End3prevyr { get; set; }

    public decimal OrigBeg3prevyr { get; set; }

    public decimal OrigEnd3prevyr { get; set; }

    public decimal Beg4prevyr { get; set; }

    public decimal End4prevyr { get; set; }

    public decimal OrigBeg4prevyr { get; set; }

    public decimal OrigEnd4prevyr { get; set; }

    public decimal Beg5prevyr { get; set; }

    public decimal End5prevyr { get; set; }

    public decimal OrigBeg5prevyr { get; set; }

    public decimal OrigEnd5prevyr { get; set; }

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public string Ref7 { get; set; } = null!;

    public string Ref8 { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }

    public virtual ICollection<BillingAccount> BillingAccounts { get; set; } = new List<BillingAccount>();

    public virtual IntercompanyBillingRevenueAccount? IntercompanyBillingRevenueAccount { get; set; }

    public virtual ICollection<PurchaseOrderInvoice> PurchaseOrderInvoices { get; set; } = new List<PurchaseOrderInvoice>();

    public virtual ICollection<PurchaseOrderLineItems> PurchaseOrderLineItems { get; set; } = new List<PurchaseOrderLineItems>();

    public virtual ICollection<PurchasingAccount> PurchasingAccounts { get; set; } = new List<PurchasingAccount>();

    public virtual ICollection<RevRecActualInvoiceHistory> RevRecActualInvoiceHistories { get; set; } = new List<RevRecActualInvoiceHistory>();

    public virtual ICollection<RevRecCategoryMapping> RevRecCategoryMappings { get; set; } = new List<RevRecCategoryMapping>();

    public virtual ICollection<RevRecInvoicingDetail> RevRecInvoicingDetails { get; set; } = new List<RevRecInvoicingDetail>();

    public virtual ICollection<RevRecProjectAccountBalance> RevRecProjectAccountBalances { get; set; } = new List<RevRecProjectAccountBalance>();

    public virtual ICollection<RevRecRevenueAccountBalance> RevRecRevenueAccountBalances { get; set; } = new List<RevRecRevenueAccountBalance>();

    public virtual ICollection<RevRecTempProjectAccountBalance> RevRecTempProjectAccountBalances { get; set; } = new List<RevRecTempProjectAccountBalance>();

    public virtual ICollection<RevRecTempProjectRevenueSummaryToCategorySummary> RevRecTempProjectRevenueSummaryToCategorySummaries { get; set; } = new List<RevRecTempProjectRevenueSummaryToCategorySummary>();

    public virtual ICollection<Rfi> Rfis { get; set; } = new List<Rfi>();

    public virtual SubcontractCrewExpenseAccount? SubcontractCrewExpenseAccount { get; set; }

    public virtual SubrentedEquipmentExpenseAccount? SubrentedEquipmentExpenseAccount { get; set; }

    public virtual ICollection<TaxAccount> TaxAccounts { get; set; } = new List<TaxAccount>();

    public virtual UsedEquipmentSalesRevenueAccount? UsedEquipmentSalesRevenueAccount { get; set; }
}
