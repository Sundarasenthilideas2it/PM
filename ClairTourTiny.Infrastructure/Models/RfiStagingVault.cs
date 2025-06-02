using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RfiStagingVault
{
    public short Spid { get; set; }

    public string Entityno { get; set; } = null!;

    public int Seqno { get; set; }

    public int? InvoiceTemplateId { get; set; }

    public int? InvoiceTemplateGroupId { get; set; }

    public DateTime? InvoicedThrough { get; set; }

    public string? Acctcd { get; set; }

    public int? OInvoiceTemplateId { get; set; }

    public int? OInvoiceTemplateGroupId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public double TotalInvoiced { get; set; }
}
