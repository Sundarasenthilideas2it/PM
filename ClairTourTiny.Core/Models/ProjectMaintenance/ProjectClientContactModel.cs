namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectClientContactModel
    {
        public string EntityNo { get; set; } = string.Empty;
        public int IdContactCategory { get; set; }
        public string ContactNo { get; set; } = string.Empty;
        public int SortOrder { get; set; }
        public string? ContactName { get; set; }
    }
}
