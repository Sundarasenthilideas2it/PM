using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectChecklistItem
{
    public int IdItem { get; set; }

    public string Category { get; set; } = null!;

    public string Subcategory { get; set; } = null!;

    public string Item { get; set; } = null!;

    public int Sortorder { get; set; }

    public string? Sqlquery { get; set; }

    public bool? IsPublic { get; set; }

    public int? DeadlineDaysBeforeStart { get; set; }

    public virtual ProjectChecklistSubCategory ProjectChecklistSubCategory { get; set; } = null!;

    public virtual ICollection<ProjectChecklistValue> ProjectChecklistValues { get; set; } = new List<ProjectChecklistValue>();

    public virtual ICollection<Inpart> Partnos { get; set; } = new List<Inpart>();

    public virtual ICollection<Pjtfrusr> UserNames { get; set; } = new List<Pjtfrusr>();
}
