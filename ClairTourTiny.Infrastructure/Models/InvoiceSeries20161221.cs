using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceSeries20161221
{
    public string Entityno { get; set; } = null!;

    public int InvoiceTemplateId { get; set; }

    public string Tag { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public string? Notes { get; set; }

    public string? BodyText { get; set; }

    public string? FooterText { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string BillSchedule { get; set; } = null!;

    public int? InvoicingTaxGroupId { get; set; }

    public int? BankAccountId { get; set; }

    public string? Paytermscd { get; set; }

    public int IdLanguage { get; set; }

    public bool DisplaySplitsOnAllInvoices { get; set; }
}
