using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class NotDuplicate
{
    public string GroupName { get; set; } = null!;

    public int UnifiedContactId { get; set; }
}
