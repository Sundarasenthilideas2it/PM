using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DevicePropertiesA
{
    public string? Partno { get; set; }

    public string? SerialNo { get; set; }

    public int? IdPropertyType { get; set; }

    public int? Seqno { get; set; }

    public string? Value { get; set; }

    public string? Note { get; set; }

    public string? UniqueNo { get; set; }

    public DateTime? AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }

    public string? OldPartNo { get; set; }

    public string? OldSerialNo { get; set; }

    public int? OldIdPropertyType { get; set; }

    public int? OldSeqno { get; set; }

    public string? OldUniqueNo { get; set; }
}
