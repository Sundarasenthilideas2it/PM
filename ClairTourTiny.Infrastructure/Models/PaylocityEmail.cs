using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PaylocityEmail
{
    public string PaylocityId { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public virtual PaylocityContact Paylocity { get; set; } = null!;

    public virtual DataType TypeNavigation { get; set; } = null!;
}
