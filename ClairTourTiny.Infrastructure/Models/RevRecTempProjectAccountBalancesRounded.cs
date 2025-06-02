using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecTempProjectAccountBalancesRounded
{
    public string Entityno { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string RevRecType { get; set; } = null!;

    public string Acctcd { get; set; } = null!;

    public double DebitAmount { get; set; }

    public double RoundedDebitAmount { get; set; }

    public double RoundingDebitDiff { get; set; }

    public double? RoundedDebitTotal { get; set; }

    public double? TotalOfRoundedDebitAmounts { get; set; }

    public double CreditAmount { get; set; }

    public double RoundedCreditAmount { get; set; }

    public double RoundingCreditDiff { get; set; }

    public double? RoundedCreditTotal { get; set; }

    public double? TotalOfRoundedCreditAmounts { get; set; }

    public int? DebitCentsToDistribute { get; set; }

    public long? DebitRoundingRank { get; set; }

    public int? CreditCentsToDistribute { get; set; }

    public long? CreditRoundingRank { get; set; }

    public double OldDebitAmount { get; set; }

    public double? NewDebitAmount { get; set; }

    public decimal? DebitAmountCentsAddedOrRemoved { get; set; }

    public double OldCreditAmount { get; set; }

    public double? NewCreditAmount { get; set; }

    public decimal? CreditAmountCentsAddedOrRemoved { get; set; }
}
