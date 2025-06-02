namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectPartModel
    {
        public string PartNo { get; set; } = string.Empty;
        public string PartDesc { get; set; } = string.Empty;
        public double? CubicInches { get; set; }
        public double? Pounds { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
