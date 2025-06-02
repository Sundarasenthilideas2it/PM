using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CleanSolutionsCustomer
{
    public string Customer { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Btaddr1 { get; set; }

    public string? Btaddr2 { get; set; }

    public string? Btcity { get; set; }

    public string? Btstate { get; set; }

    public string? Btzip { get; set; }

    public string? Staddr1 { get; set; }

    public string? Staddr2 { get; set; }

    public string? Stcity { get; set; }

    public string? Ststate { get; set; }

    public string? Stzip { get; set; }
}
