using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectChecklistValue
{
    public string Entityno { get; set; } = null!;

    public int IdItem { get; set; }

    public int? Checkvalue { get; set; }

    public string? UserName { get; set; }

    public DateTime? Datetime { get; set; }

    public string? Note { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;

    public virtual ProjectChecklistItem IdItemNavigation { get; set; } = null!;

    public virtual Pjtfrusr? UserNameNavigation { get; set; }
}
