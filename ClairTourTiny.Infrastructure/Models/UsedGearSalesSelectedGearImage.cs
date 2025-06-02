using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UsedGearSalesSelectedGearImage
{
    public string Partno { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

    public string ImageSeo { get; set; } = null!;
}
