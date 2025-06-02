using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllUserInfo
{
    public string UserName { get; set; } = null!;

    public string Empname { get; set; } = null!;

    public string OwnerEntity { get; set; } = null!;

    public string WarehouseEntity { get; set; } = null!;

    public string TourEntity { get; set; } = null!;

    public string? CompanyCode { get; set; }

    public string SalesForecastGroup { get; set; } = null!;

    public string DefaultBillingCompany { get; set; } = null!;

    public string DefaultDivision { get; set; } = null!;

    public string DefaultPropType { get; set; } = null!;

    public string DefaultPrinterPaperSize { get; set; } = null!;

    public string StartupProgram { get; set; } = null!;

    public string DoubleclickProgramProject { get; set; } = null!;

    public string DoubleclickProgramNoProject { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public int IdLanguage { get; set; }

    public string Unitofweight { get; set; } = null!;

    public double? ConversionFactorFromPounds { get; set; }

    public byte WeightDecimalPlaces { get; set; }

    public string Unitoflength { get; set; } = null!;

    public double? ConversionFactorFromInches { get; set; }

    public byte LengthDecimalPlaces { get; set; }

    public byte VolumeDecimalPlaces { get; set; }

    public string FirstDayOfWeek { get; set; } = null!;

    public int? SqlFirstDayOfWeek { get; set; }

    public string TimezoneName { get; set; } = null!;

    public short? TimezoneHoursDelta { get; set; }

    public int AvailabilityEstoffsetHours { get; set; }

    public string? Email { get; set; }

    public string Culture { get; set; } = null!;
}
