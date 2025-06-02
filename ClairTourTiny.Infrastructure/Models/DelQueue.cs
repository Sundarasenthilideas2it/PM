using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DelQueue
{
    public byte Status { get; set; }

    public byte? Priority { get; set; }

    public long QueuingOrder { get; set; }

    public Guid ConversationGroupId { get; set; }

    public Guid ConversationHandle { get; set; }

    public long MessageSequenceNumber { get; set; }

    public string ServiceName { get; set; } = null!;

    public int ServiceId { get; set; }

    public string ServiceContractName { get; set; } = null!;

    public int ServiceContractId { get; set; }

    public string MessageTypeName { get; set; } = null!;

    public int MessageTypeId { get; set; }

    public string Validation { get; set; } = null!;

    public byte[]? MessageBody { get; set; }

    public DateTime? MessageEnqueueTime { get; set; }

    public string? CastedMessageBody { get; set; }
}
