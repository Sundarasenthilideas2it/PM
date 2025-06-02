using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoicePieces1678891320250225
{
    public string Entityno { get; set; } = null!;

    public int InvoiceTemplateId { get; set; }

    public int? InvoiceTemplateGroupId { get; set; }

    public int Seqno { get; set; }

    public DateTime InvoiceStartDate { get; set; }

    public DateTime ChunkStartDate { get; set; }

    public DateTime ChunkEndDate { get; set; }

    public string? Description { get; set; }

    public string Acctcd { get; set; } = null!;

    public double Total { get; set; }

    public int? SortOrder { get; set; }

    public string Notes { get; set; } = null!;

    public int InvoiceSeqno { get; set; }

    public decimal? ChunkTotalNotRounded { get; set; }

    public decimal? ChunkTotalRounded { get; set; }

    public int? RfichunkRowId { get; set; }

    public int? RoundingRank { get; set; }

    public bool? RoundingRestriction { get; set; }

    public decimal? ChunkRounding { get; set; }
}
