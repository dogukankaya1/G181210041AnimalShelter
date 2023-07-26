namespace AnimalShelter.Models
{
    public class Application
    {
        public int ApplicationId { get; set; }
        public bool isSubmit { get; set; }
        //1 submitting 0 adopting
        public bool isApproved { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public Animal Animal { get; set; }

        //public ICollection<Animal>? Animal { get; set; }
        //applying for many animals in application

    }
}
