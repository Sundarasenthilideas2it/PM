using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DeviceMaintenanceTypesWarehouseReport
{
    public int MaintenanceTypeId { get; set; }

    public string WarehouseCode { get; set; } = null!;

    public int StickerHtmlIdTemplate { get; set; }

    public int? SmallStickerHtmlIdTemplate { get; set; }

    public virtual DeviceMaintenanceType MaintenanceType { get; set; } = null!;

    public virtual HtmlReportTemplate? SmallStickerHtmlIdTemplateNavigation { get; set; }

    public virtual HtmlReportTemplate StickerHtmlIdTemplateNavigation { get; set; } = null!;

    public virtual Warehouse WarehouseCodeNavigation { get; set; } = null!;
}
