using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseQueriesCategory
{
    public string Category { get; set; } = null!;

    public int? Sortorder { get; set; }

    public virtual ICollection<MyFinesseNavigationCollapsedCategory1> MyFinesseNavigationCollapsedCategory1s { get; set; } = new List<MyFinesseNavigationCollapsedCategory1>();

    public virtual ICollection<MyFinesseQuery> MyFinesseQueries { get; set; } = new List<MyFinesseQuery>();
}
