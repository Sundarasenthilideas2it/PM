using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ReferralProgram
{
    public byte ReferralProgramId { get; set; }

    public string ReferralProgramDesc { get; set; } = null!;

    public virtual ICollection<Glentity> Glentities { get; set; } = new List<Glentity>();
}
