using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

public class ProductionScheduleDto
{
    public int Id { get; set; }
    public string EntityNo { get; set; }
    public string EventType { get; set; }
    public string Description { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Location { get; set; }
    public string Status { get; set; }
    public string Notes { get; set; }
    public string Phase { get; set; }
    public bool IsMilestone { get; set; }
    public int SortOrder { get; set; }
} 