using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TransferToolsMobileCheckInOutLog
{
    public string UserName { get; set; } = null!;

    public DateTime DateStamp { get; set; }

    public string InOutType { get; set; } = null!;
}
