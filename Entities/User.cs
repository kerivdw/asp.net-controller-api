using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asp.net_controller_api.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateofBirth { get; set; }

        public ICollection<User> Users { get; set; } = new List<User>();

        public User(string firstName,string lastName, DateTime DateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = DateOfBirth;
        }
    }
}
