using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanPartsOnProjectsToImport
{
    public string? ElementType { get; set; }

    public string? Entityno { get; set; }

    public int Seqno { get; set; }

    public string? Partdesc { get; set; }

    public string? Partno { get; set; }

    public DateTime? PickupDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public float Qty { get; set; }

    public float QtySubrented { get; set; }

    public string Id { get; set; } = null!;

    public string? UpstreamLineItemId { get; set; }

    public string? QuoteSubphase { get; set; }

    public string? QuoteSubcaption { get; set; }

    public string? NoteText { get; set; }

    public string? EqlistId { get; set; }

    public string? ParentItemId { get; set; }

    public string? OpsSubphase { get; set; }

    public string? OpsSubcaption { get; set; }
}
