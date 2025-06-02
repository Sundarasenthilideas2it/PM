using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaPartsOnOrderFixMismappedPart
{
    public int IdStockType2Job { get; set; }

    public int IdStockType2JobType { get; set; }

    public string CaptionEn { get; set; } = null!;

    public int IdProject { get; set; }

    public string? ProjNumber { get; set; }

    public string? ProjName { get; set; }

    public string? ProjectStatusCode { get; set; }

    public string ProjType { get; set; } = null!;

    public DateTime? ProjStartDate { get; set; }

    public DateTime? ProjEndDate { get; set; }

    public decimal? ProjRentalSumPrice { get; set; }

    public int? ProjectArranger { get; set; }

    public int IdJob { get; set; }

    public string JobNumber { get; set; } = null!;

    public string JobDesc { get; set; } = null!;

    public DateTime? DayTimeOut { get; set; }

    public DateTime? DayTimeIn { get; set; }

    public decimal? JobCommitDays { get; set; }

    public int? JobSortOrder { get; set; }

    public decimal? RentalPriceSum { get; set; }

    public decimal? ItemPriceNoDiscount { get; set; }

    public string? JobEngActiveCd { get; set; }

    public string? JobPropType { get; set; }

    public string JobStateEn { get; set; } = null!;

    public int? JobArranger { get; set; }

    public int? JobGroupSort { get; set; }

    public string? JobGroupDesc { get; set; }

    public DateTime? JobGroupStart { get; set; }

    public DateTime? JobGroupEnd { get; set; }

    public int? IdStockType { get; set; }

    public decimal? SortOrder { get; set; }

    public string StockTypeNumber { get; set; } = null!;

    public string StockTypeDesc { get; set; } = null!;

    public int Factor { get; set; }

    public int? Loaded { get; set; }

    public int? Back { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public int? IdStockType2JobParent { get; set; }

    public decimal? RentalPrice { get; set; }

    public decimal? BasePrice { get; set; }

    public int IdStockType2JobGroup { get; set; }

    public int? IdTimeFactor { get; set; }

    public decimal? TimeFactor { get; set; }

    public string? Caption { get; set; }

    public decimal? FinalSortOrder { get; set; }
}
