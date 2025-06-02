using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectQuoteMonthlyTotalsHistory
{
    public string Entityno { get; set; } = null!;

    public string BillingCompany { get; set; } = null!;

    public string RevenueGroup { get; set; } = null!;

    public int Probability { get; set; }

    public string Currency { get; set; } = null!;

    public string Sfactivecd { get; set; } = null!;

    public short Year { get; set; }

    public byte Month { get; set; }

    public decimal EquipmentRevenue { get; set; }

    public decimal CrewRevenue { get; set; }

    public decimal ExpenseRevenue { get; set; }

    public decimal? TotalRevenue { get; set; }

    public DateTime ValidFromUtc { get; set; }

    public DateTime? ValidToUtc { get; set; }

    public decimal? TotalRevenueOnSalesForecast { get; set; }
}
