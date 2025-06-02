using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EquipmentSubhireStatus
{
    public string StatusCode { get; set; } = null!;

    public byte SortOrder { get; set; }

    public virtual ICollection<EquipmentSubhire> EquipmentSubhires { get; set; } = new List<EquipmentSubhire>();
}
