using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Currency
{
    public string Currency1 { get; set; } = null!;

    public string? Description { get; set; }

    public string? Symbol { get; set; }

    public bool SymbolOnLeft { get; set; }

    public string Culture { get; set; } = null!;

    public string DecimalSeparator { get; set; } = null!;

    public string ThousandsSeparator { get; set; } = null!;

    public bool BracketedNegative { get; set; }

    public bool SymbolInsideNegative { get; set; }

    public int? BidPriority { get; set; }

    public double InvoiceLineItemGranularity { get; set; }

    public double InvoiceTaxGranularity { get; set; }

    public double InvoiceGranularity { get; set; }

    public double RfienforcedGranularity { get; set; }

    public double RfidefaultGranularity { get; set; }

    public string DefaultTaxType { get; set; } = null!;

    public string DefaultVattaxType { get; set; } = null!;

    public int? CurrencyPositivePattern { get; set; }

    public decimal? CapexThreshold { get; set; }

    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

    public virtual ICollection<CrewBidValue> CrewBidValues { get; set; } = new List<CrewBidValue>();

    public virtual InvoicingTaxType DefaultTaxTypeNavigation { get; set; } = null!;

    public virtual ICollection<ExchangeRateBook> ExchangeRateBooks { get; set; } = new List<ExchangeRateBook>();

    public virtual ICollection<ExchangeRateDaily> ExchangeRateDailies { get; set; } = new List<ExchangeRateDaily>();

    public virtual ICollection<Glentity> Glentities { get; set; } = new List<Glentity>();

    public virtual ICollection<Oelocation> Oelocations { get; set; } = new List<Oelocation>();

    public virtual ICollection<PartBidValue> PartBidValues { get; set; } = new List<PartBidValue>();

    public virtual ICollection<PartSubhireVendor> PartSubhireVendors { get; set; } = new List<PartSubhireVendor>();

    public virtual ICollection<Pjtfrusr> Pjtfrusrs { get; set; } = new List<Pjtfrusr>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrders1 { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<QuoteReportVault> QuoteReportVaults { get; set; } = new List<QuoteReportVault>();

    public virtual ICollection<SysproProjectExpense> SysproProjectExpenses { get; set; } = new List<SysproProjectExpense>();
}
