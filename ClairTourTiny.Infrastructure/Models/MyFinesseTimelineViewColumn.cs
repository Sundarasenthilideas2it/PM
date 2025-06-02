using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseTimelineViewColumn
{
    public short IdQuery { get; set; }

    public string StartdateColumn { get; set; } = null!;

    public string EnddateColumn { get; set; } = null!;

    public string DescriptionColumn { get; set; } = null!;

    public string CodeColumn { get; set; } = null!;

    public int IdTimelineType { get; set; }

    public string? StatusColumn { get; set; }

    public virtual MyFinesseQuery IdQueryNavigation { get; set; } = null!;

    public virtual MyFinesseTimelineViewType IdTimelineTypeNavigation { get; set; } = null!;
}
