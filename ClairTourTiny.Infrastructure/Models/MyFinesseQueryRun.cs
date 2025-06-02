using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseQueryRun
{
    public string Username { get; set; } = null!;

    public short IdQuery { get; set; }

    public int ElapsedMilliseconds { get; set; }

    public DateTime RunDateUtc { get; set; }

    public string ServerName { get; set; } = null!;

    public virtual MyFinesseQuery IdQueryNavigation { get; set; } = null!;
}
