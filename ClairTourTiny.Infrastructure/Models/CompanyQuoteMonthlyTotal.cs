using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CompanyQuoteMonthlyTotal
{
    public string? BillingCompany { get; set; }

    public string BillingCompanyDesc { get; set; } = null!;

    public string RevenueCompanyGroup { get; set; } = null!;

    public short Year { get; set; }

    public byte Month { get; set; }

    public decimal? Equipment { get; set; }

    public decimal? Crew { get; set; }

    public decimal? Expenses { get; set; }
}
