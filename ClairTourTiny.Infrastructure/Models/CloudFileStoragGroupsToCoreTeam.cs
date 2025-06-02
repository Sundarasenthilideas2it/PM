using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CloudFileStoragGroupsToCoreTeam
{
    public int IdLevel { get; set; }

    public string CoreTeamMemberDesc { get; set; } = null!;

    public virtual CloudFileStorageGroup IdLevelNavigation { get; set; } = null!;
}
