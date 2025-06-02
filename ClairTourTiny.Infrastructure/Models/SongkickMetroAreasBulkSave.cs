using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SongkickMetroAreasBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public int Id { get; set; }

    public string Metro { get; set; } = null!;

    public string? State { get; set; }

    public string? Country { get; set; }

    public double? Lat { get; set; }

    public double? Lng { get; set; }

    public string? Region { get; set; }
}
