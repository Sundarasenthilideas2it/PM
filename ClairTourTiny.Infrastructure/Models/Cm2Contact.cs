using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Cm2Contact
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Contactno { get; set; } = null!;

    public string Contactname { get; set; } = null!;

    public string Statuscode { get; set; } = null!;

    public DateTime Enterdate { get; set; }

    public string Contacttype { get; set; } = null!;

    public bool? HideFromReceivablesReport { get; set; }

    public Guid? FileStorageGuid { get; set; }
}
