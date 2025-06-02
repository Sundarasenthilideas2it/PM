using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllocatedNewPurchaseOrderNumber
{
    public string ServerName { get; set; } = null!;

    public int Ponumber { get; set; }

    public int? OwningSessionId { get; set; }
}
