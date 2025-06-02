using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Mudbmsinfo
{
    public string? Username { get; set; }

    public string? Dbname { get; set; }

    public string? Dba { get; set; }

    public string SessionId { get; set; } = null!;

    public string? Bintim { get; set; }

    public string ServerType { get; set; } = null!;
}
