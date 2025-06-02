using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EjArJhTransAllnbcOnOrder
{
    public int IdStockType2Job { get; set; }

    public int IdJob { get; set; }

    public string JStatus { get; set; } = null!;

    public bool? IgnoreAvblCheck { get; set; }

    public string EjEntityno { get; set; } = null!;

    public int IdStockType2JobGroup { get; set; }

    public string? EjEntitydesc { get; set; }

    public string? Comment { get; set; }

    public bool? CheckOut { get; set; }

    public bool? CheckIn { get; set; }

    public bool? NextDayBack { get; set; }

    public string? CustomNumber { get; set; }

    public string? WhStj { get; set; }

    public string? WhJ { get; set; }

    public string? WhJRet { get; set; }

    public string? FPartno { get; set; }

    public string EjPartdesc { get; set; } = null!;

    public int ReqQty { get; set; }

    public DateTime? AvblDayTimeOut { get; set; }

    public DateTime? AvblDayTimeIn { get; set; }

    public DateTime? AvblDayTimeDelayBack { get; set; }

    public int? Loaded { get; set; }

    public int? Back { get; set; }

    public int? IdStockType2JobParent { get; set; }

    public string JobStockType { get; set; } = null!;

    public int IdOwner { get; set; }

    public string? Owner { get; set; }

    public string? OutLoginname { get; set; }

    public string? InLoginname { get; set; }
}
