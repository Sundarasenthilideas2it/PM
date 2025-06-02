using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanParentChildBarcodesImport
{
    public string ChildBarcode { get; set; } = null!;

    public string ChildPartno { get; set; } = null!;

    public string ParentPartno { get; set; } = null!;

    public string ParentBarcode { get; set; } = null!;

    public string ParentSerialNo { get; set; } = null!;
}
