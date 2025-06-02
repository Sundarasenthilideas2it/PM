using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DeviceMaintenanceType
{
    public int MaintenanceTypeId { get; set; }

    public string MaintenanceTypeDesc { get; set; } = null!;

    public bool EnableAutoPrintStickerWhenSelected { get; set; }

    public bool IsVisible { get; set; }

    public virtual ICollection<DeviceMaintenanceTypesWarehouseReport> DeviceMaintenanceTypesWarehouseReports { get; set; } = new List<DeviceMaintenanceTypesWarehouseReport>();
}
