using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RackConfiguratorHistory
{
    public DateTime ValidFromUtc { get; set; }

    public DateTime? ValidToUtc { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? RemovedBy { get; set; }

    public string Entityno { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public int DeviceCount { get; set; }

    public int RackBay { get; set; }

    public int RackRow { get; set; }

    public string? BoardendPartno { get; set; }

    public string? ExtensionPartno { get; set; }

    public int? CableColor { get; set; }

    public string? PatchinginNotes { get; set; }

    public string? PatchingoutNotes { get; set; }

    public string? RackPartno { get; set; }

    public bool? HalfDeviceOnRight { get; set; }

    public string? DeviceNote { get; set; }

    public bool? IsRearView { get; set; }
}
