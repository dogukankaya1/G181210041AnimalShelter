using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AnimalShelter.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; } //format?

        public ICollection<Application>? Application { get; set; }
        public ICollection<Animal>? Animal { get; set; }

    }
}
