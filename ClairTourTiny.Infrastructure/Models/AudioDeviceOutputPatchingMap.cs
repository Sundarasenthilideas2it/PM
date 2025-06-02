using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AudioDeviceOutputPatchingMap
{
    public string OutputPatching { get; set; } = null!;

    public string DeviceType { get; set; } = null!;

    public int DevicePosition { get; set; }

    public int OutputChannelNumber { get; set; }

    public int CabinetPosition { get; set; }

    public int CabinetInputNumber { get; set; }

    public virtual AudioDeviceOutputChannel AudioDeviceOutputChannel { get; set; } = null!;

    public virtual AudioOutputDevicePosition AudioOutputDevicePosition { get; set; } = null!;

    public virtual CabinetInput CabinetInputNumberNavigation { get; set; } = null!;

    public virtual CabinetPosition CabinetPositionNavigation { get; set; } = null!;

    public virtual OutputPatching OutputPatchingNavigation { get; set; } = null!;
}
