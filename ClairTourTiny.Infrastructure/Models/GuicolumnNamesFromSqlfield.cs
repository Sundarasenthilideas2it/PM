using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GuicolumnNamesFromSqlfield
{
    public string Sqlfield { get; set; } = null!;

    public string ColumnName { get; set; } = null!;
}
