using Microsoft.EntityFrameworkCore;
using Travelopia.Assignment.Entity.Models;

namespace EFCoreInMemoryDbDemo
{
    public class ApiDbContext : DbContext
    {
        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "TravelSurveyDb");
        }
        public DbSet<TravelSurveyDetails> TravelSurveys { get; set; }
    }
}
