using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class In2InvoiceSeries
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public int InvoiceTemplateId { get; set; }

    public string Entityno { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public string? Notes { get; set; }

    public string? BodyText { get; set; }

    public string? FooterText { get; set; }

    public string BillSchedule { get; set; } = null!;

    public double? Tax { get; set; }

    public int? InvoicingTaxGroupId { get; set; }

    public int? BankAccountId { get; set; }

    public string? Paytermscd { get; set; }

    public int IdLanguage { get; set; }

    public bool? DisplaySplitsOnAllInvoices { get; set; }
}
