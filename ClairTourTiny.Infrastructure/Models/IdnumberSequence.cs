using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IdnumberSequence
{
    public string ServerName { get; set; } = null!;

    public int SequenceNumber { get; set; }

    public int? OwningSessionId { get; set; }

    public string SequenceType { get; set; } = null!;

    public virtual IdnumberSequenceType SequenceTypeNavigation { get; set; } = null!;
}
