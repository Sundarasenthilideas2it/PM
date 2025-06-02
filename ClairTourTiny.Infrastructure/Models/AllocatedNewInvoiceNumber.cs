using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllocatedNewInvoiceNumber
{
    public string ServerName { get; set; } = null!;

    public int InvoiceNumber { get; set; }

    public int? OwningSessionId { get; set; }

    public string Locationcd { get; set; } = null!;

    public virtual Oelocation LocationcdNavigation { get; set; } = null!;
}
