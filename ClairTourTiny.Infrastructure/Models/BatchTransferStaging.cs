using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BatchTransferStaging
{
    public short SessionId { get; set; }

    public string Partno { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string FromBatchno { get; set; } = null!;

    public string ToBatchno { get; set; } = null!;

    public string ToBld { get; set; } = null!;

    public int Qty { get; set; }

    public virtual Glentity FromBatchnoNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;

    public virtual Glentity ToBatchnoNavigation { get; set; } = null!;
}
