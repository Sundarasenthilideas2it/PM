using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FileStorageEntityNumbersToRollup
{
    public string EntitynoBeingRolledUp { get; set; } = null!;

    public string EntitynoToRollUpTo { get; set; } = null!;

    public virtual Glentity EntitynoBeingRolledUpNavigation { get; set; } = null!;
}
