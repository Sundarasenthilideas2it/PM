using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBrpAccountsVendorAddress
{
    public string? SupplierCode { get; set; }

    public double? AddressNumber { get; set; }

    public string? Address { get; set; }

    public string? PostCode { get; set; }

    public string? Town { get; set; }

    public string? County { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public double? DefaultInvoiceAddress { get; set; }

    public double? DefaultDeliveryAddress { get; set; }

    public double? DefaultStatementAddress { get; set; }

    public double? DefaultRemittanceAddress { get; set; }

    public string? PurchaseAnalysis { get; set; }

    public string? Source { get; set; }

    public string? EMailAddress { get; set; }

    public string? Country { get; set; }
}
