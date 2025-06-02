using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceSeriesStagingVault
{
    public short Spid { get; set; }

    public string Entityno { get; set; } = null!;

    public int InvoiceTemplateId { get; set; }

    public int? NewInvoiceTemplateId { get; set; }

    public string Tag { get; set; } = null!;

    public DateTime? StartDate { get; set; }

    public string? Notes { get; set; }

    public string? BodyText { get; set; }

    public string? FooterText { get; set; }

    public string? BillSchedule { get; set; }

    public double? Tax { get; set; }

    public bool? ToDelete { get; set; }

    public string? OTag { get; set; }

    public DateTime? OStartDate { get; set; }

    public string? ONotes { get; set; }

    public string? OBodyText { get; set; }

    public string? OFooterText { get; set; }

    public string? OBillSchedule { get; set; }

    public double? OTax { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int? InvoicingTaxGroupId { get; set; }

    public int? OInvoicingTaxGroupId { get; set; }

    public int? BankAccountId { get; set; }

    public string? Paytermscd { get; set; }

    public int? OBankAccountId { get; set; }

    public string? OPaytermscd { get; set; }

    public string? BankAccountText { get; set; }

    public string? OBankAccountText { get; set; }

    public virtual BankAccount? BankAccount { get; set; }

    public virtual InvoicingTaxGroup? InvoicingTaxGroup { get; set; }

    public virtual InvoicingTaxGroup? OInvoicingTaxGroup { get; set; }

    public virtual Oepayterm? PaytermscdNavigation { get; set; }
}
