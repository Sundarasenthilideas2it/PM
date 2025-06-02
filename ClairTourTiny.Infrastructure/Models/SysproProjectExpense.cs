using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SysproProjectExpense
{
    public string Company { get; set; } = null!;

    public decimal TrnYear { get; set; }

    public decimal TrnMonth { get; set; }

    public decimal Journal { get; set; }

    public decimal EntryNumber { get; set; }

    public decimal SubEntry { get; set; }

    public string Supplier { get; set; } = null!;

    public string SupplierName { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public decimal DistrValue { get; set; }

    public DateOnly InvoiceDate { get; set; }

    public string Reference { get; set; } = null!;

    public string Invoice { get; set; } = null!;

    public string ExpenseType { get; set; } = null!;

    public string ExpenseGlCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual Currency CurrencyNavigation { get; set; } = null!;
}
