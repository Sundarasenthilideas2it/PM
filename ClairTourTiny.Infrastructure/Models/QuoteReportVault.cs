using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class QuoteReportVault
{
    public string Entityno { get; set; } = null!;

    public int Revision { get; set; }

    public int IdReporttype { get; set; }

    public int IdLanguage { get; set; }

    public string? TxtTo { get; set; }

    public string? TxtRe { get; set; }

    public string? Salutation { get; set; }

    public string? Body { get; set; }

    public int HideEquipmentList { get; set; }

    public string? EquipmentText { get; set; }

    public int HideCrewList { get; set; }

    public string? CrewText { get; set; }

    public int HideBillingPeriods { get; set; }

    public int HideBillingSummary { get; set; }

    public int HidePaymentSchedule { get; set; }

    public string? Notes { get; set; }

    public string? ProductionName { get; set; }

    public string? ArtistName { get; set; }

    public string? EventName { get; set; }

    public DateTime? TouringPeriodStartDate { get; set; }

    public DateTime? TouringPeriodEndDate { get; set; }

    public int HideScheduleB { get; set; }

    public string? ScheduleBparagraphsDeleted { get; set; }

    public string? Closing { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int HideCrewHours { get; set; }

    public int HideBillingGroupsSummary { get; set; }

    public int? HideWeeklyRates { get; set; }

    public string? TxtFrom { get; set; }

    public int? HideTotalDays { get; set; }

    public string? PerDiemPayer { get; set; }

    public int? HideScheduleC { get; set; }

    public string? ParagraphsDeleted { get; set; }

    public string? ParagraphsAmmended { get; set; }

    public string? PerDiemDomestic { get; set; }

    public string? PerDiemInternational { get; set; }

    public string? EquipmentValue { get; set; }

    public string? Deposit { get; set; }

    public int? HideItemTotals { get; set; }

    public string? PaymentTerms { get; set; }

    public bool? HideEquipmentBillingDays { get; set; }

    public bool? HideCrewDays { get; set; }

    public bool? HideExpenseDays { get; set; }

    public string? Venue { get; set; }

    public bool? HideEquipmentLineItemAmounts { get; set; }

    public string? Ponumber { get; set; }

    public bool? HideCrewLineItemAmounts { get; set; }

    public bool? HideExpensesLineItemAmounts { get; set; }

    public string? Currency { get; set; }

    public double? ExchangeRate { get; set; }

    public string? CurrencySymbol { get; set; }

    public virtual Currency? CurrencyNavigation { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;

    public virtual XlatLanguage IdLanguageNavigation { get; set; } = null!;

    public virtual QuoteReportType IdReporttypeNavigation { get; set; } = null!;

    public virtual Pjtfrusr UserNameNavigation { get; set; } = null!;
}
