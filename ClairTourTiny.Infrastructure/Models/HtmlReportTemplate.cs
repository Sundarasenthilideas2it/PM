using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class HtmlReportTemplate
{
    public int IdTemplate { get; set; }

    public string TemplateName { get; set; } = null!;

    public string? FileNameTemplate { get; set; }

    public virtual ICollection<DeviceMaintenanceTypesWarehouseReport> DeviceMaintenanceTypesWarehouseReportSmallStickerHtmlIdTemplateNavigations { get; set; } = new List<DeviceMaintenanceTypesWarehouseReport>();

    public virtual ICollection<DeviceMaintenanceTypesWarehouseReport> DeviceMaintenanceTypesWarehouseReportStickerHtmlIdTemplateNavigations { get; set; } = new List<DeviceMaintenanceTypesWarehouseReport>();

    public virtual ICollection<HtmlReportTemplateSection> HtmlReportTemplateSections { get; set; } = new List<HtmlReportTemplateSection>();
}
