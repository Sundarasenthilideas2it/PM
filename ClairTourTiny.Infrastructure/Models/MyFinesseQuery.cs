using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseQuery
{
    public short IdQuery { get; set; }

    public string Category { get; set; } = null!;

    public string? Querycaption { get; set; }

    public int? Sortorder { get; set; }

    public short? IsPublic { get; set; }

    public string? Sqlquery { get; set; }

    public bool IsTimelineview { get; set; }

    public bool IsInquiry { get; set; }

    public bool? AutoRefresh { get; set; }

    public virtual MyFinesseQueriesCategory CategoryNavigation { get; set; } = null!;

    public virtual ICollection<MyFinesseEmailNotification> MyFinesseEmailNotifications { get; set; } = new List<MyFinesseEmailNotification>();

    public virtual ICollection<MyFinesseQueriesColumnMinWidth> MyFinesseQueriesColumnMinWidths { get; set; } = new List<MyFinesseQueriesColumnMinWidth>();

    public virtual ICollection<MyFinesseQueryRun> MyFinesseQueryRuns { get; set; } = new List<MyFinesseQueryRun>();

    public virtual MyFinesseTimelineViewColumn? MyFinesseTimelineViewColumn { get; set; }

    public virtual ICollection<Pjtfrusr> UserNames { get; set; } = new List<Pjtfrusr>();
}
