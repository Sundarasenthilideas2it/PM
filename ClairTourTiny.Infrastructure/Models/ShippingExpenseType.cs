using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingExpenseType
{
    public string ExpenseTypeCode { get; set; } = null!;

    public string ExpenseTypeDesc { get; set; } = null!;

    public string ExpenseTypeDescShort { get; set; } = null!;

    public virtual ICollection<ShippingExpenseTypeDetail> ShippingExpenseTypeDetails { get; set; } = new List<ShippingExpenseTypeDetail>();
}
