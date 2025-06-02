using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ContactCategoriesCloudFileStorageGroup
{
    public int IdContactCategory { get; set; }

    public int IdLevel { get; set; }

    public virtual CloudFileStorageGroup IdLevelNavigation { get; set; } = null!;
}
