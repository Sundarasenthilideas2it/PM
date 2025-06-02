using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaResourceFunctionMapping
{
    public int IdResourceFunction { get; set; }

    public int IdResourceType { get; set; }

    public string Type { get; set; } = null!;

    public string? Caption { get; set; }

    public int IdInvoiceAccount { get; set; }

    public int IdInvoiceAccountPurchase { get; set; }

    public bool? Inactive { get; set; }

    public string? Jobtype { get; set; }
}
