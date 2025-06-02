namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectClientShippingAddressModel
    {
        public string CustNo { get; set; } = string.Empty;
        public string SubNo { get; set; } = string.Empty;
        public string ShipNo { get; set; } = string.Empty;
        public string? ShipToName { get; set; }
        public string Contact { get; set; } = string.Empty;
        public string Attention { get; set; } = string.Empty;
        public string? Addr1 { get; set; }
        public string? Addr2 { get; set; }
        public string? Addr3 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string Zip { get; set; } = string.Empty;
        public string? Country { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Ext { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Mobile { get; set; } = string.Empty;
    }
}
