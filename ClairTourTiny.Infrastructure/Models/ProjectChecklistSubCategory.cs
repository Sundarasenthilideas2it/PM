using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectChecklistSubCategory
{
    public string Category { get; set; } = null!;

    public string Subcategory { get; set; } = null!;

    public int Sortorder { get; set; }

    public virtual ProjectChecklistCategory CategoryNavigation { get; set; } = null!;

    public virtual ICollection<ProjectChecklistItem> ProjectChecklistItems { get; set; } = new List<ProjectChecklistItem>();
}
