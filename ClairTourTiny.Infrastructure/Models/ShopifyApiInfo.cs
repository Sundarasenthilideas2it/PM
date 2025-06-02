using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShopifyApiInfo
{
    public string Apipassword { get; set; } = null!;

    public string WebsiteUrl { get; set; } = null!;

    public string CompanyCode { get; set; } = null!;

    public virtual Company CompanyCodeNavigation { get; set; } = null!;
}
