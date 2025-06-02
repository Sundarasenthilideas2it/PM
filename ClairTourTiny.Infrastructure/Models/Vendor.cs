using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Vendor
{
    public string Vendno { get; set; } = null!;

    public string VendorName { get; set; } = null!;

    public string Activeind { get; set; } = null!;

    public DateTime Lastactivity { get; set; }

    public string ToName { get; set; } = null!;

    public string Parent { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string SiteNo { get; set; } = null!;

    public string Cellphone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public Guid? FileStorageGuid { get; set; }
}
