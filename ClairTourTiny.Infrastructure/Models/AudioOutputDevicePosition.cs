using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AudioOutputDevicePosition
{
    public string DeviceType { get; set; } = null!;

    public int DevicePosition { get; set; }

    public virtual ICollection<AudioDeviceOutputPatchingMap> AudioDeviceOutputPatchingMaps { get; set; } = new List<AudioDeviceOutputPatchingMap>();

    public virtual AudioOutputDeviceType DeviceTypeNavigation { get; set; } = null!;

    public virtual ICollection<StationDevice> StationDevices { get; set; } = new List<StationDevice>();
}
