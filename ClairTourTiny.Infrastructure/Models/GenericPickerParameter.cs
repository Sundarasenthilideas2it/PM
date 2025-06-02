using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GenericPickerParameter
{
    public string Title { get; set; } = null!;

    public string Sqlquery { get; set; } = null!;

    public string DisplayMember { get; set; } = null!;

    public string ValueMember { get; set; } = null!;
}
