using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IntercoCustomer
{
    public string CustomerId { get; set; } = null!;

    public string? SiteId { get; set; }

    public string? CustomerStaticticGroup { get; set; }

    public string? CustomerGroup { get; set; }

    public string? AssociationNumber { get; set; }

    public string? IfscompanyCd { get; set; }

    public string? DefaultCurrency { get; set; }

    public string? DefaultPaymentTerms { get; set; }

    public string? CounterPartyCode { get; set; }
}
