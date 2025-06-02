using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Inp2PartsA
{
    public short? SessionId { get; set; }

    public DateTime? UpdateTime { get; set; }

    public bool? IsInsert { get; set; }

    public bool? IsUpdate { get; set; }

    public bool? IsDelete { get; set; }

    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public string? Package { get; set; }

    public string? Acctno { get; set; }

    public string? PartdescSales { get; set; }

    public string? MakePurchase { get; set; }

    public string? Parent { get; set; }

    public double? Weight { get; set; }

    public string? Origin { get; set; }

    public double? BidValueUsd { get; set; }

    public double? RentalValueUsd { get; set; }

    public string? Category { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public string? Locationcd { get; set; }

    public string? PartImageFilePath { get; set; }

    public double? Ipeak120v { get; set; }

    public double? Iavg120v { get; set; }

    public double? Ipeak240v { get; set; }

    public double? Iavg240v { get; set; }

    public double? RackUnits { get; set; }

    public int? RackBays { get; set; }

    public string? MaterialDesc { get; set; }

    public double? OperatingVa { get; set; }

    public string? OperatingVacMin { get; set; }

    public string? OperatingVacMax { get; set; }

    public string? HarmonizedCode { get; set; }

    public string? HarmonizedTariff { get; set; }

    public string? FccId { get; set; }

    public string? CeMarking { get; set; }

    public string? PreferenceCriterionCode { get; set; }

    public string? ProducerCode { get; set; }

    public string? NetCostCode { get; set; }

    public bool? HideOnQuotes { get; set; }

    public int? IdManufacturer { get; set; }

    public string? ModelNo { get; set; }

    public string? TagIdeas { get; set; }

    public string? Sku { get; set; }

    public string? PrimaryCategoryCode { get; set; }

    public string? SecondaryCategoryCode { get; set; }

    public string? AlternateDesc { get; set; }

    public string? RangeType { get; set; }

    public double? SafeWorkingLoadLbs { get; set; }

    public DateTime AdateTime { get; set; }

    public string AuserId { get; set; } = null!;

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }

    public string? BarcodeLocationNote { get; set; }
}
