using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UnifiedEmail
{
    public int UnifiedContactId { get; set; }

    public string Source { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string Type { get; set; } = null!;

    public bool IsPrimary { get; set; }

    public virtual EmailDataSourceFieldMap EmailDataSourceFieldMap { get; set; } = null!;

    public virtual UnifiedContact UnifiedContact { get; set; } = null!;
}
