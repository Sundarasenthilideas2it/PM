using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UnifiedPhone
{
    public int UnifiedContactId { get; set; }

    public string Source { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public virtual PhoneDataSourceFieldMap PhoneDataSourceFieldMap { get; set; } = null!;

    public virtual UnifiedContact UnifiedContact { get; set; } = null!;
}
