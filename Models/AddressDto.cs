namespace asp.net_controller_api.Models
{
    public class AddressDto
    {
        public int Id { get; set; }
        public required string Addressline1 { get; set; }
        public string? Addressline2 { get; set; }
        public required string Suburb { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public required string PostCode { get; set; }
    }
}
