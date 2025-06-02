using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RackConfiguratorA
{
    public string? Entityno { get; set; }

    public string? Partno { get; set; }

    public int? DeviceCount { get; set; }

    public int? RackBay { get; set; }

    public int? RackRow { get; set; }

    public string? BoardendPartno { get; set; }

    public string? ExtensionPartno { get; set; }

    public int? CableColor { get; set; }

    public string? PatchinginNotes { get; set; }

    public string? PatchingoutNotes { get; set; }

    public string? RackPartno { get; set; }

    public bool? HalfDeviceOnRight { get; set; }

    public string? DeviceNote { get; set; }

    public bool? IsRearView { get; set; }

    public DateTime AdateTime { get; set; }

    public string AuserId { get; set; } = null!;

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
