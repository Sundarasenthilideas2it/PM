using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IdnumberSequenceType
{
    public string SequenceType { get; set; } = null!;

    public string SequenceDesc { get; set; } = null!;

    public string? SequencePrefix { get; set; }

    public string? SequenceSuffix { get; set; }

    public int? ZeroPadMinimumLength { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<IdnumberSequence> IdnumberSequences { get; set; } = new List<IdnumberSequence>();

    public virtual ICollection<Pjtfrusr> Pjtfrusrs { get; set; } = new List<Pjtfrusr>();
}
