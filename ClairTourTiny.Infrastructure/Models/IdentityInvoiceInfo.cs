using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IdentityInvoiceInfo
{
    public string Company { get; set; } = null!;

    public string Identity { get; set; } = null!;

    public string PartyType { get; set; } = null!;

    public string InvoiceFee { get; set; } = null!;

    public DateTime? ExpireDate { get; set; }

    public string? NationalBankCode { get; set; }

    public string? GroupId { get; set; }

    public string? DefAuthorizer { get; set; }

    public string PayTermId { get; set; } = null!;

    public string? DefVatCode { get; set; }

    public string? RoundingTaxCode { get; set; }

    public string DefCurrency { get; set; } = null!;

    public double? PaymDevDays { get; set; }

    public string IdentityType { get; set; } = null!;

    public string VotingSharePercentage { get; set; } = null!;

    public string? DefPreliminaryCode { get; set; }

    public string AutomaticInvoice { get; set; } = null!;

    public double? PercentTolerance { get; set; }

    public double? AmountTolerance { get; set; }

    public string NcfReferenceCheck { get; set; } = null!;

    public string TaxExempt { get; set; } = null!;

    public DateTime? TaxExemptValidFrom { get; set; }

    public DateTime? TaxExemptValidTo { get; set; }

    public string SecondTin { get; set; } = null!;

    public string ReportAndWithhold { get; set; } = null!;

    public string? SupplierTaxOfficeId { get; set; }

    public string? NumerationGroup { get; set; }

    public string? TaxBookId { get; set; }

    public double? TaxBookType { get; set; }

    public string? TaxStructureId { get; set; }

    public string PrintTaxCodeText { get; set; } = null!;

    public double? NoInvoiceCopies { get; set; }

    public string? DefManSuppInvType { get; set; }

    public string? DefAutoInvoiceType { get; set; }

    public string? DefRecManSuppInvType { get; set; }

    public string? TaxLiability { get; set; }

    public string WithholdingBaseAmount { get; set; } = null!;

    public string? InvoiceRecipient { get; set; }

    public string? InvoicingSupplier { get; set; }

    public string MatchingLevel { get; set; } = null!;

    public string AllowTolerance { get; set; } = null!;

    public string CreateTolerancePosting { get; set; } = null!;

    public string AllowQuantityDiff { get; set; } = null!;

    public string? DefaultCurrencyRateType { get; set; }

    public string TaxCertificateForm { get; set; } = null!;

    public string? IsNote { get; set; }

    public string? DelivTypeId { get; set; }

    public string? SupVatFreeVatCode { get; set; }

    public string? SupCountryCode { get; set; }

    public string? AutomaticPayAuthFlag { get; set; }

    public string? CustomerId { get; set; }

    public string? SupplierId { get; set; }

    public string? InactiveReasonDesc { get; set; }

    public string LegalIdentity { get; set; } = null!;

    public string? LegalIdentityDb { get; set; }

    public string PoRefRecRefValMethod { get; set; } = null!;

    public string? PostingTemplateId { get; set; }

    public string? LegalIdName { get; set; }

    public string? LegalIdAddrId { get; set; }

    public DateTime BiTimestamp { get; set; }

    public string? InvoiceReasonId { get; set; }

    public string? FiscalNo { get; set; }

    public string InvoiceRecipientFrom { get; set; } = null!;

    public string? InvoiceRecipientFromDb { get; set; }

    public string ExcFromSpesometroDec { get; set; } = null!;

    public string? ExcFromSpesometroDecDb { get; set; }

    public string ServiceCodeRequired { get; set; } = null!;

    public string? ServiceCodeRequiredDb { get; set; }

    public string? EinvoiceReceiverCode { get; set; }

    public string? PersonId { get; set; }

    public string? CertifiedEmail { get; set; }

    public string? TaxRepresentative { get; set; }

    public string IncInvCurrRateBase { get; set; } = null!;

    public string TaxBuyCurrRateBase { get; set; } = null!;

    public double? CisReferenceId { get; set; }

    public string? SupplierUtr { get; set; }

    public string? SupplyTypeCode { get; set; }

    public string? EinvoiceProcessType { get; set; }

    public string ExcludePostingAuth { get; set; } = null!;

    public string? ExcludePostingAuthDb { get; set; }

    public string ExcludeInvoiceImage { get; set; } = null!;

    public string? ExcludeInvoiceImageDb { get; set; }

    public string? ConsolidationDay { get; set; }

    public string UtilityBillProvider { get; set; } = null!;

    public string? UtilityBillProviderDb { get; set; }

    public string? Rowkey { get; set; }

    public double? Rowversion { get; set; }
}
