using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DatabaseSchemaHistory
{
    public string ObjectName { get; set; } = null!;

    public string SchemaName { get; set; } = null!;

    public DateTimeOffset ChangeDate { get; set; }

    public string EventType { get; set; } = null!;

    public string ServerName { get; set; } = null!;

    public string ObjectType { get; set; } = null!;

    public string NewState { get; set; } = null!;

    public string LoginName { get; set; } = null!;
}
