using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EjArJhTransAllnbcAddedRemovedTfr
{
    public int IdStockType2InventoryType { get; set; }

    public string Trantype { get; set; } = null!;

    public string? FPartno { get; set; }

    public int? Factor { get; set; }

    public int? Multiplier { get; set; }

    public string Partdesc { get; set; } = null!;

    public bool? SingleDeviceManagement { get; set; }

    public string? Note { get; set; }

    public int IdOwner { get; set; }

    public string? Owner { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? IdAddress { get; set; }

    public string WhStit { get; set; } = null!;

    public string? Number { get; set; }

    public int? IdStockType2JobGroup { get; set; }

    public string? Entitydesc { get; set; }

    public string? Jobstate { get; set; }

    public DateTime? DateTimeOut { get; set; }

    public DateTime? DateTimeIn { get; set; }

    public int? Loaded { get; set; }

    public int? Back { get; set; }

    public int? IdStockType2JobParent { get; set; }

    public int? IdStockType2JobType { get; set; }

    public DateTime? AvblDayTimeOut { get; set; }

    public DateTime? AvblDayTimeIn { get; set; }

    public DateTime? AvblDayTimeDelayBack { get; set; }

    public string? Caption { get; set; }

    public string? FinesseNo { get; set; }

    public int? IdStockType2InventoryTypeParent { get; set; }

    public int? IdStockType2InventoryTypeAssociated { get; set; }

    public int? IdPurchaseOrderItem { get; set; }

    public int? IdSalesJobItem { get; set; }

    public decimal? PurchasePrice { get; set; }

    public string? Loginname { get; set; }
}
