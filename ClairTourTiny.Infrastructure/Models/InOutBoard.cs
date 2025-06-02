using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InOutBoard
{
    public string UserName { get; set; } = null!;

    public bool IsIn { get; set; }

    public DateTime ActivityDate { get; set; }

    public string? Note { get; set; }
}
