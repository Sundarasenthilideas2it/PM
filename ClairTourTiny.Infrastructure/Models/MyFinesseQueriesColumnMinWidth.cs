using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseQueriesColumnMinWidth
{
    public short IdQuery { get; set; }

    public string ColumnName { get; set; } = null!;

    public int MinWidth { get; set; }

    public virtual MyFinesseQuery IdQueryNavigation { get; set; } = null!;
}
