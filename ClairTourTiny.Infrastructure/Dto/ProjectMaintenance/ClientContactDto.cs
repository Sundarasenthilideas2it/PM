using System.ComponentModel.DataAnnotations.Schema;

namespace ClairTourTiny.Infrastructure.Dto.ProjectMaintenance
{
    public class ClientContactDto
    {
        [Column("entityno")]
        public string EntityNo { get; set; } = string.Empty;

        [Column("id_ContactCategory")]
        public int IdContactCategory { get; set; }

        [Column("ContactNo")]
        public string ContactNo { get; set; } = string.Empty;

        [Column("SortOrder")]
        public int SortOrder { get; set; }

        [Column("contactname")]
        public string? ContactName { get; set; }
    }
}
