using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpApinvoiceImport
{
    public string? SupplierCode { get; set; }

    public string? TransactionType { get; set; }

    public string? InvoiceNumber { get; set; }

    public string? Date { get; set; }

    public string? DueDate { get; set; }

    public string? LineDescription { get; set; }

    public string? HeaderDescription { get; set; }

    public string? SysProNominalCode { get; set; }

    public string? Project { get; set; }

    public string? NetGbp { get; set; }

    public string? TaxGbp { get; set; }

    public string? TaxCode { get; set; }

    public string? OrderNumber { get; set; }

    public string? OrderDate { get; set; }

    public string? InvoiceDueDate { get; set; }
}
