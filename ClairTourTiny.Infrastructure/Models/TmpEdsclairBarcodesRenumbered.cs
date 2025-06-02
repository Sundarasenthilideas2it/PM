using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdsclairBarcodesRenumbered
{
    public string UniqueNo { get; set; } = null!;

    public bool IsRepair { get; set; }

    public bool IsSale { get; set; }

    public string Bld { get; set; } = null!;
}
