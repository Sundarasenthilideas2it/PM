using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class StationDevice
{
    public string StationDescription { get; set; } = null!;

    public string DeviceType { get; set; } = null!;

    public int DevicePosition { get; set; }

    public int DeviceInstanceNumber { get; set; }

    public virtual AudioOutputDevice AudioOutputDevice { get; set; } = null!;

    public virtual AudioOutputDevicePosition AudioOutputDevicePosition { get; set; } = null!;

    public virtual Station StationDescriptionNavigation { get; set; } = null!;
}
