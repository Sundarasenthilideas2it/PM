using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Customer
{
    public string Custno { get; set; } = null!;

    public string? CustName { get; set; }

    public string Activeind { get; set; } = null!;

    public DateOnly? Enterdate { get; set; }

    public string Subno { get; set; } = null!;

    public string BillToName { get; set; } = null!;

    public string Attention { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string Cellphone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool? HideFromReceivablesReport { get; set; }

    public Guid? FileStorageGuid { get; set; }
}
