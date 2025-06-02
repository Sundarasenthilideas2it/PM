using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdstemplate
{
    public string? Templateid { get; set; }

    public string? Templatename { get; set; }

    public short? Lineno { get; set; }

    public short? Quantity { get; set; }

    public string? Productid { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }
}
