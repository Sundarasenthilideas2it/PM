using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class UnplannedTransfersStagingArea
{
    public string? Empname { get; set; }

    public string? Transtype { get; set; }

    public int? Qty { get; set; }

    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public string? FromEntityNo { get; set; }

    public string? FromEntityDesc { get; set; }

    public string? ReturnWh { get; set; }

    public string? ToEntityNo { get; set; }

    public string? ToEntityDesc { get; set; }

    public string? CheckinWh { get; set; }

    public string? Email { get; set; }

    public int? R { get; set; }

    public string? Barcodes { get; set; }
}
