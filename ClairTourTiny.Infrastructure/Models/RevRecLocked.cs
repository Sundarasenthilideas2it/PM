using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RevRecLocked
{
    public string Entityno { get; set; } = null!;

    public bool IsLocked { get; set; }

    public bool IsFinalized { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime DateModified { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
