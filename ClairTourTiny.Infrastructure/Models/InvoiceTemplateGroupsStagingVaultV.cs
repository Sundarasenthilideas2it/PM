using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceTemplateGroupsStagingVaultV
{
    public string? Entityno { get; set; }

    public int InvoiceTemplateId { get; set; }

    public int? InvoiceTemplateGroupId { get; set; }

    public int? NewInvoiceTemplateGroupId { get; set; }

    public string InvoiceGroupName { get; set; } = null!;

    public int SortOrder { get; set; }

    public string Notes { get; set; } = null!;

    public string? OEntityno { get; set; }

    public int? OInvoiceTemplateId { get; set; }

    public int? OInvoiceTemplateGroupId { get; set; }

    public string? OInvoiceGroupName { get; set; }

    public string ONotes { get; set; } = null!;
}
