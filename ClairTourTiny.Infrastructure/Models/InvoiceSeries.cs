using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceSeries
{
    public string Entityno { get; set; } = null!;

    public int InvoiceTemplateId { get; set; }

    public string Tag { get; set; } = null!;

    public DateOnly StartDate { get; set; }

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

    public virtual BankAccount? BankAccount { get; set; }

    public virtual PjBillSchedule BillScheduleNavigation { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;

    public virtual XlatLanguage IdLanguageNavigation { get; set; } = null!;

    public virtual ICollection<InvoiceSeriesGroup> InvoiceSeriesGroups { get; set; } = new List<InvoiceSeriesGroup>();

    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public virtual InvoicingTaxGroup? InvoicingTaxGroup { get; set; }

    public virtual Oepayterm? PaytermscdNavigation { get; set; }

    public virtual ICollection<Rfi> Rfis { get; set; } = new List<Rfi>();
}
