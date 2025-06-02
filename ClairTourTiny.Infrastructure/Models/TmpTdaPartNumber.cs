using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaPartNumber
{
    public string EjpartNo { get; set; } = null!;

    public string? Manufacturer { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string Description { get; set; } = null!;

    public decimal? Purchase { get; set; }

    public int IdStockType { get; set; }

    public int IdOwner { get; set; }

    public int IdStockTypeCategory { get; set; }

    public string Number { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public int? Inventory { get; set; }

    public string? Comment { get; set; }

    public decimal? Weight { get; set; }

    public byte? MaxAllowance { get; set; }

    public decimal? Height { get; set; }

    public decimal? Width { get; set; }

    public decimal? Depth { get; set; }

    public bool? DrainStockType { get; set; }

    public bool? DisableAvaliableCheck { get; set; }

    public string? CustomNumber { get; set; }

    public int? IdCountryManufacturer { get; set; }

    public string? Barcode { get; set; }

    public bool? EnableService { get; set; }

    public decimal? RealPower { get; set; }

    public decimal? ApparentPower { get; set; }

    public bool? Flightcase { get; set; }

    public bool? Printable { get; set; }

    public int? InventoryBase { get; set; }

    public int? IdTimeFactor { get; set; }

    public bool? RmBizPublish { get; set; }

    public decimal? UtilisationPlan { get; set; }

    public int? IdUserCreated { get; set; }

    public int? IdUserUpdated { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? IdShortCutDefaultPicture { get; set; }

    public int? CategorySortOrder { get; set; }

    public bool? IgnoreStats { get; set; }

    public bool? IgnoreAvblCheck { get; set; }

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

    public int? IdTaxValue { get; set; }

    public int? IdTaxValueSales { get; set; }

    public int? MarketingStockTypeAvailMode { get; set; }

    public bool? IsMarketingStockType { get; set; }

    public int? Condition { get; set; }

    public int? IdCostCenter { get; set; }

    public string? PolicyComment { get; set; }

    public decimal? RentalsPerYear { get; set; }

    public decimal? Usage { get; set; }

    public decimal? Volume { get; set; }

    public int? IdAddressManufacturer { get; set; }

    public int? IdUnit { get; set; }

    public decimal? WeightNet { get; set; }

    public decimal? HeightNet { get; set; }

    public decimal? WidthNet { get; set; }

    public decimal? DepthNet { get; set; }

    public decimal? VolumeNet { get; set; }

    public int? PackingUnit { get; set; }

    public string? PowerConnection { get; set; }

    public string? RateOfDutyNumber { get; set; }

    public int? IdCostCenterSales { get; set; }

    public int? IdCostCenterSalesUsed { get; set; }

    public int? PreperationMinutes { get; set; }

    public int? PostProcessingMinutes { get; set; }

    public string? BookingWarning { get; set; }

    public bool? ForceDefaultLocation { get; set; }

    public bool? StockTypeLocationEnabled { get; set; }

    public int? WorkflowPolicy { get; set; }

    public int? IdWorkflowDefinitionBooking { get; set; }

    public bool? ExcludeAgentAgreementFee { get; set; }

    public bool? AvblInclCheckOutIn { get; set; }

    public bool? Published2WebShopSales { get; set; }

    public bool? Published2WebShopSalesUsed { get; set; }

    public int? WebShopSalesUsedInventory { get; set; }

    public int? IdDangerousGoodsLabel { get; set; }

    public int? IdWorkflowDefinitionLoading { get; set; }

    public int? IdWorkflowDefinitionUnloading { get; set; }
}
