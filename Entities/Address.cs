using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace asp.net_controller_api.Entities
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public required string Addressline1 { get; set; }
        
        public string? Addressline2 { get; set; }

        [Required]
        public required string Suburb { get; set; }

        [Required]
        public required string City { get; set; }

        [Required]
        public required string Country { get; set; }

        [Required]
        public required string PostCode { get; set; }
    }
}
