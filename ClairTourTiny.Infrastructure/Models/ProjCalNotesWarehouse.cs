using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjCalNotesWarehouse
{
    public int WarehouseNoteId { get; set; }

    public string Warehouse { get; set; } = null!;

    public DateTime? Date { get; set; }

    public string NoteTag { get; set; } = null!;

    public string Note { get; set; } = null!;

    public bool IsPrivate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime? DateModified { get; set; }

    public virtual Warehouse WarehouseNavigation { get; set; } = null!;
}
