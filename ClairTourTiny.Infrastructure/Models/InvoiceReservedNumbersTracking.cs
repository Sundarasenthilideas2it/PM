using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceReservedNumbersTracking
{
    public string InvoiceReservedNumber { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public DateTime ReserveNumberCreated { get; set; }

    public string Action { get; set; } = null!;
}
