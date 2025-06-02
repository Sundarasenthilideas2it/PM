using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AudioDeviceOutputChannel
{
    public string DeviceType { get; set; } = null!;

    public int OutputChannelNumber { get; set; }

    public string SignalLevel { get; set; } = null!;

    public virtual ICollection<AudioDeviceOutputPatchingMap> AudioDeviceOutputPatchingMaps { get; set; } = new List<AudioDeviceOutputPatchingMap>();

    public virtual AudioOutputDeviceType DeviceTypeNavigation { get; set; } = null!;

    public virtual SignalLevel SignalLevelNavigation { get; set; } = null!;
}
