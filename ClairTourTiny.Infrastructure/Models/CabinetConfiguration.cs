using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CabinetConfiguration
{
    public string Partno { get; set; } = null!;

    public string Configuration { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public virtual Cabinet PartnoNavigation { get; set; } = null!;

    public virtual ICollection<ReferenceSet1> ReferenceSet1s { get; set; } = new List<ReferenceSet1>();

    public virtual ICollection<StackTestDevice> StackTestDevices { get; set; } = new List<StackTestDevice>();
}
