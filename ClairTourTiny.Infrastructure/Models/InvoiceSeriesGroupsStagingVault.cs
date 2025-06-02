using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InvoiceSeriesGroupsStagingVault
{
    public short Spid { get; set; }

    public string? Entityno { get; set; }

    public int InvoiceTemplateId { get; set; }

    public int? InvoiceTemplateGroupId { get; set; }

    public int? NewInvoiceTemplateGroupId { get; set; }

    public string InvoiceGroupName { get; set; } = null!;

    public int SortOrder { get; set; }

    public string? OEntityno { get; set; }

    public int? OInvoiceTemplateId { get; set; }

    public int? OInvoiceTemplateGroupId { get; set; }

    public string? OInvoiceGroupName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string ONotes { get; set; } = null!;
}
