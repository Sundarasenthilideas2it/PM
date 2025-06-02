using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArAddressType
{
    public int IdAddressType { get; set; }

    public string Caption { get; set; } = null!;

    public int? AddressTypeFlag { get; set; }
}
