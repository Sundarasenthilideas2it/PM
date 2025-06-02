using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpWexlerBarcodesRentedByClair
{
    public string? Barcode { get; set; }

    public string? CompanyName { get; set; }

    public string? PartNo { get; set; }

    public string? PartDesc { get; set; }

    public string? JobNo { get; set; }

    public string? JobDesc { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? WorkOrderDesc { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }
}
