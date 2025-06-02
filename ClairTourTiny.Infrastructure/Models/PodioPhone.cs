using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PodioPhone
{
    public string PodioId { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public virtual PodioContact Podio { get; set; } = null!;

    public virtual DataType TypeNavigation { get; set; } = null!;
}
