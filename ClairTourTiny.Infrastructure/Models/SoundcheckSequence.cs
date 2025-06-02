using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SoundcheckSequence
{
    public string Sequence { get; set; } = null!;

    public string Sequencelocation { get; set; } = null!;

    public virtual ICollection<Inpart> Inparts { get; set; } = new List<Inpart>();
}
