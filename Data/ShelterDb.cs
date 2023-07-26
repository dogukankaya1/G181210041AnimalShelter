using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace AnimalShelter.Data
{
    public class ShelterDb:DbContext
    {

        public DbSet<Person> Persons { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Application> Applications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
                Database=KitaplikDatabase;Trusted_Connection=True;");

             }


    }
}
