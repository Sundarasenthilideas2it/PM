using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjCalNotesProj
{
    public int ProjNoteId { get; set; }

    public string? Entityno { get; set; }

    public bool? IsIncoming { get; set; }

    public string NoteTag { get; set; } = null!;

    public string Note { get; set; } = null!;

    public bool IsPrivate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public virtual Glentity? EntitynoNavigation { get; set; }
}
