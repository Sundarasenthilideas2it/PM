using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpsDeviceProperty
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Partno { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public int IdPropertyType { get; set; }

    public int Seqno { get; set; }

    public string Value { get; set; } = null!;

    public string? Note { get; set; }

    public string? UniqueNo { get; set; }
}
