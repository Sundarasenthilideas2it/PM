using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Ratiogroup
{
    public int GroupId { get; set; }

    public string GroupDesc { get; set; } = null!;

    public decimal TargetRatio { get; set; }

    public virtual ICollection<RatiogroupsFormula> RatiogroupsFormulas { get; set; } = new List<RatiogroupsFormula>();
}
