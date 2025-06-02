using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ParentsWithChildrenWithMismatchedOwnership
{
    public string Wh { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string ParentPartNo { get; set; } = null!;

    public string ParentPartDesc { get; set; } = null!;

    public string ParentBarcode { get; set; } = null!;

    public string ParentOwner { get; set; } = null!;

    public string ChildPartNo { get; set; } = null!;

    public int ChildQty { get; set; }

    public string ChildPartDesc { get; set; } = null!;

    public string ChildBarcode { get; set; } = null!;

    public string ChildOwner { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public DateTime ReturnDate { get; set; }
}
