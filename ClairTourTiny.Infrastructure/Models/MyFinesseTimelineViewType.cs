using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseTimelineViewType
{
    public int IdTimelineType { get; set; }

    public string TimelineType { get; set; } = null!;

    public virtual ICollection<MyFinesseTimelineViewColumn> MyFinesseTimelineViewColumns { get; set; } = new List<MyFinesseTimelineViewColumn>();
}
