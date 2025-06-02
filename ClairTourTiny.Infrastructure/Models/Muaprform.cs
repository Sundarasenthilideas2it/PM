using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Muaprform
{
    public string Formname { get; set; } = null!;

    public string Fieldname1 { get; set; } = null!;

    public string Fieldname2 { get; set; } = null!;

    public string Fieldname3 { get; set; } = null!;

    public string Fieldname4 { get; set; } = null!;

    public string Fieldname5 { get; set; } = null!;

    public string Fieldname6 { get; set; } = null!;

    public string Fieldname7 { get; set; } = null!;

    public string Fieldname8 { get; set; } = null!;

    public string Fieldname9 { get; set; } = null!;

    public string ObjType { get; set; } = null!;

    public string ChainAlias { get; set; } = null!;

    public string DisplayButton { get; set; } = null!;

    public string CanChange { get; set; } = null!;

    public string DetailButton { get; set; } = null!;

    public string DetailTable { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
