using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace asp.net_controller_api.Entities
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Addressline1 { get; set; }
        public string? Addressline2 { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public required string PostCode { get; set; }

        public ICollection<Address> UserAddress { get; set; } = new List<Address>();

        public Address(string addressLine1, string addressLine2, string suburb, string city, string country, string postcode) 
        { 
            Addressline1 = addressLine1;
            Addressline2 = addressLine2;
            Suburb = suburb;
            City = city;
            Country = country;
            PostCode = postcode;        
        }
    }
}
