using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmailDataSourceFieldMap
{
    public string Source { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Value { get; set; }

    public bool MultipleAllowed { get; set; }

    public virtual DataSource SourceNavigation { get; set; } = null!;

    public virtual DataType TypeNavigation { get; set; } = null!;

    public virtual ICollection<UnifiedEmail> UnifiedEmails { get; set; } = new List<UnifiedEmail>();
}
