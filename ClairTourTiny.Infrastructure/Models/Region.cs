using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Region
{
    public string Region1 { get; set; } = null!;

    public virtual ICollection<Country> Countries { get; set; } = new List<Country>();

    public virtual ICollection<SongkickMetroArea> SongkickMetroAreas { get; set; } = new List<SongkickMetroArea>();
}
