using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpVersacomPartTypes20211004
{
    public int IdStockType { get; set; }

    public int IdOwner { get; set; }

    public int IdStockTypeCategory { get; set; }

    public string Number { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public int? Inventory { get; set; }

    public string? Type { get; set; }

    public string? Comment { get; set; }

    public decimal? Weight { get; set; }

    public decimal? PurchasePrice { get; set; }

    public decimal? SalesPrice { get; set; }

    public decimal? SubhirePrice { get; set; }

    public decimal? LeasePrice { get; set; }

    public decimal? ImputedPrice { get; set; }

    public byte? MaxAllowance { get; set; }

    public decimal? Height { get; set; }

    public decimal? Width { get; set; }

    public decimal? Depth { get; set; }

    public bool? DrainStockType { get; set; }

    public bool? DisableAvaliableCheck { get; set; }

    public string? CustomNumber { get; set; }

    public int? IdCountryManufacturer { get; set; }

    public string? StorageLocation { get; set; }

    public string? Barcode { get; set; }

    public bool? BreakPartlist { get; set; }

    public int? BlockIndicator { get; set; }

    public bool? EnableService { get; set; }

    public int? MinimumStockLevel { get; set; }

    public decimal? RealPower { get; set; }

    public decimal? ApparentPower { get; set; }

    public bool? Flightcase { get; set; }

    public bool? Printable { get; set; }

    public int? InventoryBase { get; set; }

    public Guid? Gusn { get; set; }

    public int? IdTimeFactor { get; set; }

    public string? FactoryNumber { get; set; }

    public string? PackingInstruction { get; set; }

    public string? CustomsTariffNumber { get; set; }

    public bool? RmBizPublish { get; set; }

    public decimal? UtilisationPlan { get; set; }

    public int? StockWithInventoryFlag { get; set; }

    public int? IdUserCreated { get; set; }

    public int? IdUserUpdated { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? IdShortCutDefaultPicture { get; set; }

    public int? CategorySortOrder { get; set; }

    public bool? IgnoreStats { get; set; }

    public bool? IgnoreAvblCheck { get; set; }

    public bool? GotBoundRefs { get; set; }

    public bool? NeedRefPopup { get; set; }

    public int? InventorySales { get; set; }

    public bool? IsRentalStockType { get; set; }

    public bool? IsSalesStockType { get; set; }

    public int? IdDepreciationMethod { get; set; }

    public decimal? EconomicLife { get; set; }

    public int? IdShortCutManual { get; set; }

    public bool? Published2WebShop { get; set; }

    public int? ScannerBehaviorFlag { get; set; }

    public decimal? PirealCosts { get; set; }

    public bool? NoDiscount { get; set; }

    public bool? RmautoLicenceUpdate { get; set; }

    public bool? SparePart { get; set; }

    public bool? SingleDeviceManagement { get; set; }

    public int? PolicyFlag { get; set; }
}
