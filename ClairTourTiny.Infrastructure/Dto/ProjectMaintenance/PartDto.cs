using System.ComponentModel.DataAnnotations.Schema;

namespace ClairTourTiny.Infrastructure.Dto.ProjectMaintenance
{
    public class PartDto
    {
        [Column("PartNo")]
        public string PartNo { get; set; } = string.Empty;

        [Column("PartDesc")]
        public string PartDesc { get; set; } = string.Empty;

        [Column("CubicInches")]
        public double? CubicInches { get; set; }

        [Column("Pounds")]
        public double? Pounds { get; set; }

        [Column("Category")]
        public string Category { get; set; } = string.Empty;
    }
}
