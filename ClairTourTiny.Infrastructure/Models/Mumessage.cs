using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Mumessage
{
    public string MsgNo { get; set; } = null!;

    public string MsgLine { get; set; } = null!;

    public string MsgText { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
