using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ServiceModel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Toolname { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Host { get; set; } = null!;

    public int Port { get; set; }

    public bool Active { get; set; }
}
