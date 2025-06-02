using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPlus4AccountExecMapping
{
    public string PersonResponsibleId { get; set; } = null!;

    public string FinesseEmpno { get; set; } = null!;

    public string? ResourceName { get; set; }

    public string? DisplayString { get; set; }
}
