namespace ClairTourTiny.Infrastructure.Dto.Projects
{
    public class ProjectSearchDto
    {
        public required string EntityNo { get; set; }
        public required string EntityDesc { get; set; }
        public required string StatusGroup { get; set; }
        public required int SortOrder { get; set; }
    }
}
