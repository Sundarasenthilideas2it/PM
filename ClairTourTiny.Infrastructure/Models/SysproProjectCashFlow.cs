using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SysproProjectCashFlow
{
    public string? RootEntityno { get; set; }

    public string Entitydesc { get; set; } = null!;

    public string? ArInvoiceBalance { get; set; }

    public string? CashCollectedToDateAr { get; set; }

    public DateOnly? LastArActivity { get; set; }

    public string? PrepaidPortionOfCashPaidToDateAp { get; set; }

    public string? CashPaidToDateAp { get; set; }

    public string? NetCash { get; set; }

    public string? Arinvoices { get; set; }
}
