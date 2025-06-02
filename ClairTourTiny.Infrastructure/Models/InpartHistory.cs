using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartHistory
{
    public DateTime ValidFromUtc { get; set; }

    public DateTime? ValidToUtc { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? RemovedBy { get; set; }

    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public string Commmodity { get; set; } = null!;

    public string LeadSource { get; set; } = null!;

    public string Package { get; set; } = null!;

    public string Locationcd { get; set; } = null!;

    public double? LengthUom { get; set; }

    public double? DepthUom { get; set; }

    public double? WidthUom { get; set; }

    public string Acctno { get; set; } = null!;

    public string Commodity2 { get; set; } = null!;

    public string MaterialDesc { get; set; } = null!;

    public string MaterialSpecs { get; set; } = null!;

    public double Projpercent { get; set; }

    public string? Source { get; set; }

    public double Totmatcost1 { get; set; }

    public string Needkanbancard { get; set; } = null!;

    public string Needcompletionreport { get; set; } = null!;

    public string? Soundchecksequence { get; set; }

    public string? UserCreated { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UserModified { get; set; }

    public DateTime? ModifiedTime { get; set; }

    public string? PartImageFilePath { get; set; }

    public double? Ipeak120v { get; set; }

    public double? Iavg120v { get; set; }

    public double? Ipeak240v { get; set; }

    public double? Iavg240v { get; set; }

    public double? RackUnits { get; set; }

    public int? RackBays { get; set; }

    public double? OperatingVa { get; set; }

    public string? OperatingVacMin { get; set; }

    public string? OperatingVacMax { get; set; }

    public DateTime? DimsVerifiedDate { get; set; }

    public string? DimsVerifiedUser { get; set; }

    public DateTime? WeightVerifiedDate { get; set; }

    public string? WeightVerifiedUser { get; set; }

    public string? HarmonizedCode { get; set; }

    public string? HarmonizedTariff { get; set; }

    public string? FccId { get; set; }

    public string? CeMarking { get; set; }

    public string? PreferenceCriterionCode { get; set; }

    public string? ProducerCode { get; set; }

    public string? NetCostCode { get; set; }

    public bool HideOnQuotes { get; set; }

    public int? IdManufacturer { get; set; }

    public string? ModelNo { get; set; }

    public Guid Guid { get; set; }

    public double? RentalValueUsd { get; set; }

    public string? Sku { get; set; }

    public string? RangeType { get; set; }

    public string? PrimaryCategoryCode { get; set; }

    public string? SecondaryCategoryCode { get; set; }

    public string? AlternateDesc { get; set; }
}
