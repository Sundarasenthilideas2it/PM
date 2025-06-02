using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartNumberExistenceReference
{
    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;
}
