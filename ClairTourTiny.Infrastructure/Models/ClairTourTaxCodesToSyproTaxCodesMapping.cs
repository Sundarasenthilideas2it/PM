using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ClairTourTaxCodesToSyproTaxCodesMapping
{
    public string CompanyCode { get; set; } = null!;

    public string TaxTypeKey { get; set; } = null!;

    public string TaxCode { get; set; } = null!;

    public virtual Company CompanyCodeNavigation { get; set; } = null!;

    public virtual InvoicingTaxType TaxTypeKeyNavigation { get; set; } = null!;
}
