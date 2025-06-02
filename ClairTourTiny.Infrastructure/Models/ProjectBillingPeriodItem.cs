using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectBillingPeriodItem
{
    public string BidEntityno { get; set; } = null!;

    public short Periodno { get; set; }

    public byte Itemno { get; set; }

    public bool IsActive { get; set; }

    public bool ShowOnQuoteReport { get; set; }

    public double? MarkUpOrDiscountPercent { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Grouptype { get; set; }

    public int Sortorder { get; set; }

    public int? TotalItemDays { get; set; }

    public int? BidDays { get; set; }

    public double? BillingDays { get; set; }

    public double DailyRate { get; set; }

    public double WeeklyRate { get; set; }

    public double? Total { get; set; }

    public string? Proptype { get; set; }

    public string? PeriodType { get; set; }
}
