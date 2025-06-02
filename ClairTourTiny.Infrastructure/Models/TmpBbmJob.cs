using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBbmJob
{
    public int? IdJob { get; set; }

    public int? IdJobState { get; set; }

    public int? IdProject { get; set; }

    public string? Number { get; set; }

    public string? Caption { get; set; }

    public string? Comment { get; set; }

    public DateTime? DayTimeOut { get; set; }

    public DateTime? DayTimeIn { get; set; }

    public int? CheckOut { get; set; }

    public int? CheckIn { get; set; }

    public int? NextDayBack { get; set; }

    public int? Cleared { get; set; }

    public int? ClearedPercent { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CustomNumber { get; set; }
}
