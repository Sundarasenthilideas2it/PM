using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AudioOutputDevice
{
    public string DeviceType { get; set; } = null!;

    public int DeviceInstanceNumber { get; set; }

    public string? Barcode { get; set; }

    public string? SerialNo { get; set; }

    public byte[]? FrameLow { get; set; }

    public byte[]? FrameHigh { get; set; }

    public byte[]? Macaddress { get; set; }

    public virtual AudioOutputDeviceType DeviceTypeNavigation { get; set; } = null!;

    public virtual StationDevice? StationDevice { get; set; }
}
