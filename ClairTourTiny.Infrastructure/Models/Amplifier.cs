using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Amplifier
{
    public byte[] FrameLow { get; set; } = null!;

    public byte[] FrameHigh { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? SerialNo { get; set; }
}
