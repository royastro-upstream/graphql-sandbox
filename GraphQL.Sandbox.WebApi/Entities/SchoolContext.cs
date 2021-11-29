using Microsoft.EntityFrameworkCore;

namespace GraphQL.Sandbox.WebApi.Entities
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(): base()
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=SchoolDB;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
