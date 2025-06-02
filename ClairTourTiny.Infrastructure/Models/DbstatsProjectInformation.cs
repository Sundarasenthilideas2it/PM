using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DbstatsProjectInformation
{
    public string? ProjectName { get; set; }

    public DateTime? ProjectDateTime { get; set; }

    public string? AuthorName { get; set; }

    public DateTime AuthorDateTime { get; set; }

    public string? Comment { get; set; }

    public string? Password { get; set; }

    public string? AppVersionR1 { get; set; }

    public string? AppVersionArrayCalc { get; set; }

    public string? DbVersion { get; set; }
}
