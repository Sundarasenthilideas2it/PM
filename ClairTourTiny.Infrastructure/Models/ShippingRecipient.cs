using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingRecipient
{
    public string? RecipientName { get; set; }

    public string? RecipientPhone { get; set; }

    public string? RecipientEmail { get; set; }

    public string Emp { get; set; } = null!;

    public int? UseCount { get; set; }
}
