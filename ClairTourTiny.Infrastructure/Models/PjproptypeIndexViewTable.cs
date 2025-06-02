using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PjproptypeIndexViewTable
{
    public string Proptype { get; set; } = null!;

    public bool IsUtilized { get; set; }

    public bool IsTransferring { get; set; }

    public bool IsAvailable { get; set; }

    public bool IsRepair { get; set; }
}
