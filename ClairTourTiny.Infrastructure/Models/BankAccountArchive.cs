using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BankAccountArchive
{
    public int BankAccountId { get; set; }

    public string BankAccountDescription { get; set; } = null!;

    public string InvoiceText { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public string? Iban { get; set; }

    public string? Bic { get; set; }

    public string? RoutingNumber { get; set; }

    public string? SwiftCode { get; set; }

    public string? SortCode { get; set; }

    public string BillingCompany { get; set; } = null!;
}
