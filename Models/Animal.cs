using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AnimalShelter.Models
{
    public class Animal
    {
         public int AnimalId { get; set; }

        [MaxLength(100)]
        [Display(Name = "Its given name")]
        public string? PetName { get; set; }
        [Display(Name="Age, if known")]
        public int? Age { get; set; }

        // public int SubmitterId { get; set; }
        // public int ApplicantId { get; set; }
        public int ApplicationId { get; set; }
        public int PersonId { get; set; }
        // public Submitter Submitter { get; set; } 
        // public Applicant Applicant { get; set; }
        public Application Application { get; set; }
        public Person Person { get; set; }

    }
}
