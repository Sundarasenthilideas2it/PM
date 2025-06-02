using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdacrewDemandsBak
{
    public int IdResourceFunctionAllocation { get; set; }

    public int? IdJob { get; set; }

    public string Number { get; set; } = null!;

    public string JobStateEn { get; set; } = null!;

    public string? FinesseProjNo { get; set; }

    public string? Jobtype { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public decimal? DaysInAction { get; set; }

    public decimal? DayPayment { get; set; }

    public decimal? HourPayment { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public decimal? TotalPrice { get; set; }

    public decimal? TotalCosts { get; set; }

    public int? Quantity { get; set; }

    public int? QuantityInvoice { get; set; }

    public int IdResourceFunction { get; set; }

    public string ResourceType { get; set; } = null!;

    public string? Caption { get; set; }

    public int IdInvoiceAccount { get; set; }

    public int IdInvoiceAccountPurchase { get; set; }

    public bool? Inactive { get; set; }
}
