using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartsubCompare
{
    public byte[]? SysP2pCdId { get; set; }

    public string UniqueNo { get; set; } = null!;

    public DateTime Receipt { get; set; }
}
