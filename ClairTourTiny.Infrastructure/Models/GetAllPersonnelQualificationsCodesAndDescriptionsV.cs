using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class GetAllPersonnelQualificationsCodesAndDescriptionsV
{
    public string JobType { get; set; } = null!;

    public string JobTypeCode { get; set; } = null!;

    public string JobTypeDesc { get; set; } = null!;

    public string DataSource { get; set; } = null!;
}
