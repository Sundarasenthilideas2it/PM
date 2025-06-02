using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EjArJhTransBcOnOrder
{
    public int IdStockItem { get; set; }

    public int IdStockType { get; set; }

    public string EjPartno { get; set; } = null!;

    public string? FPartno { get; set; }

    public string EjPartdesc { get; set; } = null!;

    public string? Barcode { get; set; }

    public string? Serialnumber { get; set; }

    public int? IIdOwner { get; set; }

    public string? IOwner { get; set; }

    public decimal? Price { get; set; }

    public int? T2jIdstock { get; set; }

    public string? T2jWh { get; set; }

    public int? IdStockReturn { get; set; }

    public string? WhRet { get; set; }

    public int Idstocktype2job { get; set; }

    public bool IBack { get; set; }

    public int Idjob { get; set; }

    public string Caption { get; set; } = null!;

    public int? IdJobService { get; set; }

    public string EjEntityno { get; set; } = null!;

    public string? CustomNumberJ { get; set; }

    public int IdStockType2JobGroup { get; set; }

    public string EjEntitydesc { get; set; } = null!;

    public decimal? RentalPriceSum { get; set; }

    public DateTime? WtfCheckOutDate { get; set; }

    public DateTime? DayTimeOutJ { get; set; }

    public DateTime? DayTimeInJ { get; set; }

    public DateTime? DayTimeDelayBackJ { get; set; }

    public bool? CheckOut { get; set; }

    public bool? CheckIn { get; set; }

    public bool? NextDayBack { get; set; }

    public DateTime? Datetimeout { get; set; }

    public DateTime? Datetimein { get; set; }

    public int? Loaded { get; set; }

    public int? TBack { get; set; }

    public DateTime? AvblDayTimeOut { get; set; }

    public DateTime? AvblDayTimeIn { get; set; }

    public DateTime? AvblDayTimeDelayBack { get; set; }

    public int? IdStock { get; set; }

    public string? FinesseCaption { get; set; }

    public DateTime? AvblStart { get; set; }

    public DateTime? AvblEnd { get; set; }

    public int? IdStockItem2JobParent { get; set; }

    public int? ParIdstockitem { get; set; }

    public int? ParIdstocktype { get; set; }

    public string? ParEjPartno { get; set; }

    public string? ParFPartno { get; set; }

    public string? ParPartdesc { get; set; }

    public string? BarcodeP { get; set; }

    public string? SerialnumberP { get; set; }

    public string? OutLoginname { get; set; }

    public string? InLoginname { get; set; }
}
