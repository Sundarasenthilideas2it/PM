using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DelInpartsubSyd
{
    public string UniqueNo { get; set; } = null!;

    public byte[]? SysP2pCdId { get; set; }

    public DateTime? Receipt { get; set; }
}
