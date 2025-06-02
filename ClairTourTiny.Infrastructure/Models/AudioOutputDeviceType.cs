using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AudioOutputDeviceType
{
    public string DeviceType { get; set; } = null!;

    public virtual ICollection<AudioDeviceOutputChannel> AudioDeviceOutputChannels { get; set; } = new List<AudioDeviceOutputChannel>();

    public virtual ICollection<AudioOutputDevicePosition> AudioOutputDevicePositions { get; set; } = new List<AudioOutputDevicePosition>();

    public virtual ICollection<AudioOutputDevice> AudioOutputDevices { get; set; } = new List<AudioOutputDevice>();
}
