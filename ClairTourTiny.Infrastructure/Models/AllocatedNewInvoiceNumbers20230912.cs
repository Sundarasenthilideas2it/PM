using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllocatedNewInvoiceNumbers20230912
{
    public string ServerName { get; set; } = null!;

    public int InvoiceNumber { get; set; }

    public int? OwningSessionId { get; set; }

    public string Locationcd { get; set; } = null!;
}
