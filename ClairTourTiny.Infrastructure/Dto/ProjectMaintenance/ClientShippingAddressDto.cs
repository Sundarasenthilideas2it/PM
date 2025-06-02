using System.ComponentModel.DataAnnotations.Schema;

namespace ClairTourTiny.Infrastructure.Dto.ProjectMaintenance
{
    public class ClientShippingAddressDto
    {
        [Column("custno")]
        public string CustNo { get; set; } = string.Empty;

        [Column("subno")]
        public string SubNo { get; set; } = string.Empty;

        [Column("shipno")]
        public string ShipNo { get; set; } = string.Empty;

        [Column("ship_to_name")]
        public string? ShipToName { get; set; }

        [Column("contact")]
        public string Contact { get; set; } = string.Empty;

        [Column("attention")]
        public string Attention { get; set; } = string.Empty;

        [Column("addr1")]
        public string? Addr1 { get; set; }

        [Column("addr2")]
        public string? Addr2 { get; set; }

        [Column("addr3")]
        public string? Addr3 { get; set; }

        [Column("city")]
        public string? City { get; set; }

        [Column("state")]
        public string? State { get; set; }

        [Column("zip")]
        public string Zip { get; set; } = string.Empty;

        [Column("country")]
        public string? Country { get; set; }

        [Column("phone")]
        public string Phone { get; set; } = string.Empty;

        [Column("ext")]
        public string Ext { get; set; } = string.Empty;

        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [Column("mobile")]
        public string Mobile { get; set; } = string.Empty;
    }
}
