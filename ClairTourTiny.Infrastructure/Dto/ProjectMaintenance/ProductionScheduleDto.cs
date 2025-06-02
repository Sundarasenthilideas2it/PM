using System.ComponentModel.DataAnnotations.Schema;

namespace ClairTourTiny.Infrastructure.Dto.ProjectMaintenance
{
    public class ProductionScheduleDto
    {
        [Column("entityno")]
        public string EntityNo { get; set; } = string.Empty;

        [Column("EventType")]
        public string EventType { get; set; } = string.Empty;

        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        [Column("EndDate")]
        public DateTime? EndDate { get; set; }

        [Column("VenueID")]
        public int? VenueID { get; set; }

        [Column("DestinationDetail")]
        public string? DestinationDetail { get; set; }

        [Column("Note")]
        public string? Note { get; set; }

        [Column("LocationName")]
        public string? LocationName { get; set; }

        [Column("DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}
