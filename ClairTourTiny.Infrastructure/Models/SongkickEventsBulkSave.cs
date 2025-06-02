using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SongkickEventsBulkSave
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

    public bool? Cancelled { get; set; }

    public string? EventType { get; set; }

    public string? EventName { get; set; }
}
