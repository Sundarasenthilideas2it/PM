using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Glentitytype
{
    public string Entitytype { get; set; } = null!;

    public string Entitytypedesc { get; set; } = null!;

    public virtual ICollection<Glentity> Glentities { get; set; } = new List<Glentity>();
}
