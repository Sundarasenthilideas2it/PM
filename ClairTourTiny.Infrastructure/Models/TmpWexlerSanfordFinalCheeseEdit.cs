using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpWexlerSanfordFinalCheeseEdit
{
    public string? FinessePartNo { get; set; }

    public string? WexlerPartNo { get; set; }

    public string? Barcode { get; set; }

    public double? UnitOlv { get; set; }

    public string? LastKnownLocation { get; set; }

    public double? AtClair { get; set; }

    public double? ProbAtClair { get; set; }

    public double? SoldOrLease { get; set; }

    public double? InWexWh { get; set; }

    public double? OutOnRental { get; set; }

    public double? Retired { get; set; }

    public double? Missing { get; set; }

    public double? Tbd { get; set; }

    public int? RowId { get; set; }
}
