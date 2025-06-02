using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EjStockType2JobLog
{
    public int IdStockType2JobLog { get; set; }

    public int IdLogAction { get; set; }

    public int? IdUser { get; set; }

    public int? IdJob { get; set; }

    public int? IdStockType { get; set; }

    public int? OldFactor { get; set; }

    public int? NewFactor { get; set; }

    public DateTime? LogDateTime { get; set; }

    public int? IdStockType2JobGroup { get; set; }

    public int? IdStockType2JobLogSource { get; set; }
}
