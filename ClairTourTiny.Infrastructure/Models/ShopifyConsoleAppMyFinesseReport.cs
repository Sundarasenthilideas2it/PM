using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShopifyConsoleAppMyFinesseReport
{
    public string CompanyCode { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string ErrorMessage { get; set; } = null!;
}
