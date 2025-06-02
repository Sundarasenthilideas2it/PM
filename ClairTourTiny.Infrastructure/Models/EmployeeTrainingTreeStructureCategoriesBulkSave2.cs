using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeTrainingTreeStructureCategoriesBulkSave2
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string? NodeDescriptionOld { get; set; }

    public string? NodeDescriptionNew { get; set; }

    public string? ParentNodeDescription { get; set; }
}
