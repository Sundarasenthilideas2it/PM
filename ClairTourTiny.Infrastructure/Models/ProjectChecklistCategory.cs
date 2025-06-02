using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectChecklistCategory
{
    public string Category { get; set; } = null!;

    public int Sortorder { get; set; }

    public short? Chronology { get; set; }

    public virtual ICollection<ProjectChecklistSubCategory> ProjectChecklistSubCategories { get; set; } = new List<ProjectChecklistSubCategory>();
}
