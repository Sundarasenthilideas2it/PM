using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class StatutoryFee
{
    public string Company { get; set; } = null!;

    public string FeeCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double FeeRate { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidUntil { get; set; }

    public string? FeeType { get; set; }

    public string VatReceived { get; set; } = null!;

    public string VatDisbursed { get; set; } = null!;

    public double Deductible { get; set; }

    public double? AmountNotTaxable { get; set; }

    public double? MinWithheldAmount { get; set; }

    public string UseWithholdAmountTable { get; set; } = null!;

    public string TaxAmountAtInvPrint { get; set; } = null!;

    public double? TaxAmtLimit { get; set; }

    public double? MinimumBaseAmount { get; set; }

    public string? TaxReportingCategory { get; set; }

    public string TaxTypeCategory { get; set; } = null!;

    public string TaxInTaxBase { get; set; } = null!;

    public string? TaxLiabilityClass { get; set; }

    public string? SiiExemptReason { get; set; }

    public string? BusinessTransTypeCust { get; set; }

    public string? BusinessTransTypeSup { get; set; }

    public string ExcludeFromSiiReporting { get; set; } = null!;

    public string? SiiOperationType { get; set; }

    public string EuOperation { get; set; } = null!;

    public string DiotTaxClassification { get; set; } = null!;

    public string TaxFactor { get; set; } = null!;

    public string StampDuty { get; set; } = null!;

    public string RoundZeroDecimal { get; set; } = null!;

    public string TaxCharacter { get; set; } = null!;

    public string? TaxCategory1 { get; set; }

    public string? TaxCategory2 { get; set; }

    public DateTime Rowversion { get; set; }

    public string Rowkey { get; set; } = null!;

    public string? CreditTaxCode { get; set; }
}
