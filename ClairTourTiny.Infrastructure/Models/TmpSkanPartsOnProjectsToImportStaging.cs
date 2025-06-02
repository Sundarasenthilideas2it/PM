using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanPartsOnProjectsToImportStaging
{
    public string? Entityno { get; set; }

    public int Seqno { get; set; }

    public string? Partdesc { get; set; }

    public string? Partno { get; set; }

    public DateTime? PickupDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public float Qty { get; set; }

    public string MfgDesc { get; set; } = null!;

    public float QtySubrented { get; set; }

    public string Id { get; set; } = null!;

    public string? EqlistId { get; set; }
}
