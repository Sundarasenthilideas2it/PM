using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Contact
{
    public string Contactno { get; set; } = null!;

    public string Contactname { get; set; } = null!;

    public string Statuscode { get; set; } = null!;

    public DateTime Enterdate { get; set; }

    public string? Name1 { get; set; }

    public string Name2 { get; set; } = null!;

    public string Name3 { get; set; } = null!;

    public string Cellphone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool? HideFromReceivablesReport { get; set; }

    public string Contacttype { get; set; } = null!;

    public Guid? FileStorageGuid { get; set; }
}
