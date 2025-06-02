using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBbmStockTypeCategory
{
    public double? IdStockTypeCategory { get; set; }

    public double? IdStockTypeCategoryParent { get; set; }

    public string? Caption { get; set; }

    public double? SortPosition { get; set; }

    public double? IdInvoiceAccount { get; set; }

    public double? IdTimeFactor { get; set; }

    public double? MainSortOrder { get; set; }

    public double? IdInvoiceAccountSales { get; set; }

    public double? IdInvoiceAccountPurchaseRentalInventory { get; set; }

    public double? IdInvoiceAccountWorkshopActivityMaintenance { get; set; }

    public double? IdInvoiceAccountWorkshopActivityRepair { get; set; }

    public double? IdInvoiceAccountPurchaseSalesInventory { get; set; }

    public double? IdInvoiceAccountSubhire { get; set; }

    public double? IdTaxValue { get; set; }

    public double? IdTaxValueSales { get; set; }

    public string? CaptionLng2 { get; set; }

    public string? CaptionLng3 { get; set; }

    public string? CaptionLng4 { get; set; }

    public string? CaptionLng5 { get; set; }

    public string? CaptionLng6 { get; set; }

    public string? IdCostCenter { get; set; }

    public double? IdSubSection { get; set; }

    public double? IdInvoiceAccountLeaseSale { get; set; }

    public string? IdCostCenterSales { get; set; }

    public string? IdCostCenterSalesUsed { get; set; }

    public double? IdInvoiceAccountWorkshopActivityMaintenanceIncome { get; set; }

    public double? IdInvoiceAccountWorkshopActivityRepairIncome { get; set; }

    public double? CusLineFactorDefault { get; set; }

    public double? Sortable { get; set; }
}
