using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingExpenseTypeDetail
{
    public int ExpenseTypeDetailCode { get; set; }

    public string ExpenseTypeCode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? NotePrompt { get; set; }

    public int? SortOrder { get; set; }

    public bool ReqProjectNoRef { get; set; }

    public double MarkUpFactor { get; set; }

    public bool IsVisible { get; set; }

    public virtual ShippingExpenseType ExpenseTypeCodeNavigation { get; set; } = null!;

    public virtual ICollection<ShippingRequestForShipmentVault> ShippingRequestForShipmentVaults { get; set; } = new List<ShippingRequestForShipmentVault>();
}
