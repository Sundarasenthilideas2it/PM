using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RfiStagingVaultV
{
    public string Entityno { get; set; } = null!;

    public int Seqno { get; set; }

    public int? InvoiceTemplateId { get; set; }

    public int? InvoiceTemplateGroupId { get; set; }

    public string? Acctcd { get; set; }

    public int? OInvoiceTemplateId { get; set; }

    public int? OInvoiceTemplateGroupId { get; set; }
}
