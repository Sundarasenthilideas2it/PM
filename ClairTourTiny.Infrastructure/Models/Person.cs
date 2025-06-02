using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Person
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public int? Mother { get; set; }

    public int? Father { get; set; }
}
