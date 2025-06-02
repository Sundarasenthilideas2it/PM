using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeContact
{
    public string Username { get; set; } = null!;

    public string EmployeeId { get; set; } = null!;

    public string? Name { get; set; }

    public string? Organization { get; set; }

    public string? Location { get; set; }

    public string? Department { get; set; }

    public string? JobCode { get; set; }

    public string? JobType { get; set; }

    public string? JobTitle { get; set; }

    public string? Status { get; set; }

    public string? PictureFilePath { get; set; }
}
