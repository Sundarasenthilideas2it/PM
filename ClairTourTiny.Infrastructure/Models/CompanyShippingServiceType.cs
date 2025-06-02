using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CompanyShippingServiceType
{
    public string CompanyCode { get; set; } = null!;

    public string VendorFriendlyName { get; set; } = null!;

    public string AccountNo { get; set; } = null!;

    public virtual Company CompanyCodeNavigation { get; set; } = null!;
}
