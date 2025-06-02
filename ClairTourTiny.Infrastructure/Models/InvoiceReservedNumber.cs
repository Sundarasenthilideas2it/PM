using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceReservedNumber
{
    public string InvoiceReservedNumber1 { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public DateTime ReserveNumberCreated { get; set; }
}
