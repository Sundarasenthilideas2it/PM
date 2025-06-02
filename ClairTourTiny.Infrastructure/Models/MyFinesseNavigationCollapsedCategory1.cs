using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseNavigationCollapsedCategory1
{
    public string UserName { get; set; } = null!;

    public string Category { get; set; } = null!;

    public virtual MyFinesseQueriesCategory CategoryNavigation { get; set; } = null!;
}
