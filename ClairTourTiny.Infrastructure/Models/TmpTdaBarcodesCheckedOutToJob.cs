using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaBarcodesCheckedOutToJob
{
    public string? Barcode { get; set; }

    public string ProjectNo { get; set; } = null!;

    public string ProjectDesc { get; set; } = null!;

    public string JobNo { get; set; } = null!;

    public string JobDesc { get; set; } = null!;

    public int? JobGroupSort { get; set; }

    public string? EntityNo { get; set; }

    public DateTime? DayTimeOut { get; set; }

    public DateTime? DayTimeIn { get; set; }

    public string? ProjAe { get; set; }

    public string? JobAe { get; set; }

    public string JobState { get; set; } = null!;

    public int IdStockItem2Job { get; set; }

    public int IdStockType2Job { get; set; }

    public int IdStockItem { get; set; }

    public bool Back { get; set; }

    public int? IdStockItem2JobParent { get; set; }

    public int? OperatingHours { get; set; }

    public DateTime? CheckOutDate { get; set; }

    public DateTime? CheckInDate { get; set; }

    public int? IdJobPartOut { get; set; }

    public int? IdJobPartIn { get; set; }

    public int? IdStockTypeServiceFollow { get; set; }

    public DateTime? FinalCheckOutDate { get; set; }

    public int? IdStockItem2JobParentUnload { get; set; }
}
