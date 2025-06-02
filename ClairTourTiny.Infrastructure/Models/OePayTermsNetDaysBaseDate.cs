using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class OePayTermsNetDaysBaseDate
{
    public string BaseDatecd { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<Oepayterm> Oepayterms { get; set; } = new List<Oepayterm>();
}
