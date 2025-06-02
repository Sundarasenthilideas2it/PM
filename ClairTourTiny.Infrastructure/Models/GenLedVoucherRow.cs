using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GenLedVoucherRow
{
    public string Company { get; set; } = null!;

    public string VoucherType { get; set; } = null!;

    public double AccountingYear { get; set; }

    public decimal VoucherNo { get; set; }

    public double RowNo { get; set; }

    public double YearPeriodKey { get; set; }

    public double? InternalSeqNumber { get; set; }

    public double PostingCombinationId { get; set; }

    public DateTime VoucherDate { get; set; }

    public string Account { get; set; } = null!;

    public string? CodeB { get; set; }

    public string? CodeC { get; set; }

    public string? CodeD { get; set; }

    public string? CodeE { get; set; }

    public string? CodeF { get; set; }

    public string? CodeG { get; set; }

    public string? CodeH { get; set; }

    public string? CodeI { get; set; }

    public string? CodeJ { get; set; }

    public string? TransCode { get; set; }

    public double? CurrencyDebetAmount { get; set; }

    public double? CurrencyCreditAmount { get; set; }

    public decimal? CurrencyAmount { get; set; }

    public double? DebetAmount { get; set; }

    public double? CreditAmount { get; set; }

    public decimal? Amount { get; set; }

    public string? Correction { get; set; }

    public string? CurrencyCode { get; set; }

    public double? Quantity { get; set; }

    public string? ProcessCode { get; set; }

    public string? OptionalCode { get; set; }

    public double? ProjectActivityId { get; set; }

    public string? PeriodAllocation { get; set; }

    public string? Text { get; set; }

    public string? PartyType { get; set; }

    public string? PartyTypeId { get; set; }

    public string? ReferenceSerie { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? TransferId { get; set; }

    public string? AutCodingRule { get; set; }

    public double? OrgParentRow { get; set; }

    public double? ParentRow { get; set; }

    public string? Autobook { get; set; }

    public double? AutCodingSeq { get; set; }

    public double? AutCodingParentRow { get; set; }

    public string? InternalAccounting { get; set; }

    public string? CurrAccounting { get; set; }

    public string? CurrAccountingDb { get; set; }

    public string? ProjectAccounting { get; set; }

    public string? ProjectAccountingDb { get; set; }

    public string? Summerized { get; set; }

    public string? SummerizedDb { get; set; }

    public double? OldRowNo { get; set; }

    public double? OldPeriod { get; set; }

    public string? Corrected { get; set; }

    public string? HeaderCorrection { get; set; }

    public double? ThirdCurrencyDebitAmount { get; set; }

    public double? ThirdCurrencyCreditAmount { get; set; }

    public decimal? ThirdCurrencyAmount { get; set; }

    public double AccountingPeriod { get; set; }

    public double? CurrencyRate { get; set; }

    public double? ConversionFactor { get; set; }

    public string? MultiCompanyId { get; set; }

    public string? IsMultiCompanyVoucher { get; set; }

    public DateOnly? MatchingDate { get; set; }

    public int? MatchingPeriod { get; set; }

    public string? MatchingNo { get; set; }

    public int? MatchingYear { get; set; }

    public string? MatchingInfo { get; set; }

    public double? AutomaticMatchingNo { get; set; }

    public double? ReferenceRowNo { get; set; }

    public string? AutoTaxVouEntry { get; set; }

    public DateOnly? NcfSettlementDate { get; set; }

    public double? SequenceNo { get; set; }

    public double? MpccomAccountingId { get; set; }

    public string? ActivateCode { get; set; }

    public string? JournalId { get; set; }

    public double? RowGroupId { get; set; }

    public double? AllocationId { get; set; }

    public double? AllocLineId { get; set; }

    public string? CreatorDesc { get; set; }

    public string? ProjectId { get; set; }

    public string? ObjectId { get; set; }

    public string? ExcludePeriodicalCap { get; set; }

    public decimal? ParallelCurrencyRate { get; set; }

    public decimal? ParallelConversionFactor { get; set; }

    public string? DelivTypeId { get; set; }

    public string? CounterAccount { get; set; }

    public string? LedgerCountAcc { get; set; }

    public string? SeveralCountAcc { get; set; }

    public double? MultiCompanyAccYear { get; set; }

    public string? MultiCompanyVoucherType { get; set; }

    public double? MultiCompanyVoucherNo { get; set; }

    public double? MultiCompanyRowNo { get; set; }

    public string? TaxBookId { get; set; }

    public string? TaxSeriesId { get; set; }

    public double? TaxSeriesNo { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? Rowversion { get; set; }

    public string? Rowkey { get; set; }

    public string? VouTextUdpdated { get; set; }
}
