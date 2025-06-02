using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjinventoryRawDatum
{
    public string? PartArticleNo { get; set; }

    public string? DeviceArticleNo { get; set; }

    public string? PartDescOrSn { get; set; }

    public decimal? ValueAus { get; set; }
}
