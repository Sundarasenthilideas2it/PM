using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeAttachment
{
    public string Empno { get; set; } = null!;

    public string AttachmentType { get; set; } = null!;

    public string EmployeeAttachmentPath { get; set; } = null!;

    public virtual AttachmentType AttachmentTypeNavigation { get; set; } = null!;
}
