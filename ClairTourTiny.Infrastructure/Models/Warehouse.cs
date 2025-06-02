using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Warehouse
{
    public string WarehouseCode { get; set; } = null!;

    public string WarehouseDesc { get; set; } = null!;

    public string? CompanyCode { get; set; }

    public string SalesForecastGroup { get; set; } = null!;

    public string FirstDayOfWeek { get; set; } = null!;

    public short? TimezoneHoursDelta { get; set; }

    public bool IsVisible { get; set; }

    public bool DoUtilization { get; set; }

    public bool IsCheckoutInWarehouse { get; set; }

    public int AvailabilityEstoffsetHours { get; set; }

    public string? BidProjectChangeRecipients { get; set; }

    public string? Locationcd { get; set; }

    public string TimezoneName { get; set; } = null!;

    public DateTimeOffset? WarehouseLocalTime { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? Region { get; set; }

    public string? LateReturnsRecipients { get; set; }

    public string? CycleCountRecipients { get; set; }

    public bool IncludeInCrewTools { get; set; }

    public string? TransferOrderOpsManager { get; set; }

    public string? TransferOrderSecondaryOpsManager { get; set; }

    public string? TransferOrderAcctExec { get; set; }

    public string? TransferOrderBillingCompany { get; set; }

    public bool RequireShippingCostOnFedex { get; set; }

    public virtual TodayInTimeZone AvailabilityEstoffsetHoursNavigation { get; set; } = null!;

    public virtual ICollection<CommodityNotificationRecipient> CommodityNotificationRecipients { get; set; } = new List<CommodityNotificationRecipient>();

    public virtual Company? CompanyCodeNavigation { get; set; }

    public virtual ICollection<DeviceMaintenanceTypesWarehouseReport> DeviceMaintenanceTypesWarehouseReports { get; set; } = new List<DeviceMaintenanceTypesWarehouseReport>();

    public virtual ICollection<Glentity> Glentities { get; set; } = new List<Glentity>();

    public virtual ICollection<Inpartsub> Inpartsubs { get; set; } = new List<Inpartsub>();

    public virtual Oelocation? LocationcdNavigation { get; set; }

    public virtual ICollection<NotificationWarehouseEmailRecipient> NotificationWarehouseEmailRecipients { get; set; } = new List<NotificationWarehouseEmailRecipient>();

    public virtual ICollection<PartCheckinNotification> PartCheckinNotifications { get; set; } = new List<PartCheckinNotification>();

    public virtual ICollection<PartTransactionsExternal> PartTransactionsExternals { get; set; } = new List<PartTransactionsExternal>();

    public virtual ICollection<Peemployee> Peemployees { get; set; } = new List<Peemployee>();

    public virtual ICollection<Pjtfrusr> Pjtfrusrs { get; set; } = new List<Pjtfrusr>();

    public virtual ICollection<ProjCalNotesWarehouse> ProjCalNotesWarehouses { get; set; } = new List<ProjCalNotesWarehouse>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrders1 { get; set; } = new List<PurchaseOrder1>();

    public virtual GeographicalRegion? RegionNavigation { get; set; }

    public virtual SalesForecastGroup SalesForecastGroupNavigation { get; set; } = null!;

    public virtual ICollection<SalesForecastGroupOverride> SalesForecastGroupOverrides { get; set; } = new List<SalesForecastGroupOverride>();

    public virtual ICollection<ShippingPricePerPound> ShippingPricePerPounds { get; set; } = new List<ShippingPricePerPound>();

    public virtual ICollection<TransferOrderWarehouseToAndFrom> TransferOrderWarehouseToAndFromFromWarehouseCodeNavigations { get; set; } = new List<TransferOrderWarehouseToAndFrom>();

    public virtual ICollection<TransferOrderWarehouseToAndFrom> TransferOrderWarehouseToAndFromToWarehouseCodeNavigations { get; set; } = new List<TransferOrderWarehouseToAndFrom>();

    public virtual ICollection<UserWarehouseGroupsWarehouse> UserWarehouseGroupsWarehouses { get; set; } = new List<UserWarehouseGroupsWarehouse>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    public virtual ICollection<WarehouseCycleCount> WarehouseCycleCounts { get; set; } = new List<WarehouseCycleCount>();

    public virtual ICollection<WarehouseHoliday> WarehouseHolidays { get; set; } = new List<WarehouseHoliday>();

    public virtual WarehouseLateReturnsLastNotification? WarehouseLateReturnsLastNotification { get; set; }

    public virtual ICollection<ZebraPrinter> ZebraPrinters { get; set; } = new List<ZebraPrinter>();

    public virtual ICollection<XlatLanguage> IdLanguages { get; set; } = new List<XlatLanguage>();

    public virtual ICollection<Pjtfrusr> UserNames { get; set; } = new List<Pjtfrusr>();
}
