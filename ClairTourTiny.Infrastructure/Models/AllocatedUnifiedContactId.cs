using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllocatedUnifiedContactId
{
    public string ServerName { get; set; } = null!;

    public int UnifiedContactId { get; set; }

    public int? OwningSessionId { get; set; }
}
