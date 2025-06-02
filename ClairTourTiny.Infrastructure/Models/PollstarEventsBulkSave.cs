using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PollstarEventsBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public DateTime PlayDate { get; set; }

    public int ArtistId { get; set; }

    public int VenueId { get; set; }

    public string ActCode { get; set; } = null!;

    public int? StateId { get; set; }

    public int? EventId { get; set; }
}
