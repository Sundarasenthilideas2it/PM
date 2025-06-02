using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartChangesToNotify
{
    public Guid Id { get; set; }

    public string PartNumber { get; set; } = null!;

    public string PartDescription { get; set; } = null!;

    public string MessageType { get; set; } = null!;

    public DateTime RecordCreatedAt { get; set; }

    public DateTime RecordUpdatedAt { get; set; }

    public string? RawBody { get; set; }

    public string? RawError { get; set; }

    public int RetryCount { get; set; }

    public bool IsSent { get; set; }
}
