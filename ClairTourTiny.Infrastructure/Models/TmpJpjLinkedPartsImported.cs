using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjLinkedPartsImported
{
    public string? CPartNumber { get; set; }

    public string? PPartNumber { get; set; }

    public decimal Factor { get; set; }

    public int IdRefernceType { get; set; }
}
