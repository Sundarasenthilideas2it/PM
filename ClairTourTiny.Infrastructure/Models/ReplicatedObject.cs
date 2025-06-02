using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ReplicatedObject
{
    public long ObjectId { get; set; }

    public string ObjectName { get; set; } = null!;

    public string ObjectSchema { get; set; } = null!;

    public string TypeCode { get; set; } = null!;

    public string TypeDesc { get; set; } = null!;

    public bool IsReplicated { get; set; }

    public bool Ignore { get; set; }

    public DateTime FirstDetected { get; set; }
}
