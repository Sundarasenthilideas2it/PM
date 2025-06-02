using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SysproInvoicePusherInvoiceErrorMessage
{
    public string InvoiceNumber { get; set; } = null!;

    public string SysproCompanyBeingPushedTo { get; set; } = null!;

    public string ErrorMessage { get; set; } = null!;

    public DateTimeOffset? LastAttemptedPush { get; set; }
}
