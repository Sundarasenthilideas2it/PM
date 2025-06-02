using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class MyFinesseMultiGridConfig
{
    public string UserName { get; set; } = null!;

    public short IdQuery { get; set; }

    public short Row { get; set; }

    public short Col { get; set; }

    public short Rowspan { get; set; }

    public short Colspan { get; set; }

    public string Tabname { get; set; } = null!;

    public virtual Pjtfrusr UserNameNavigation { get; set; } = null!;
}
