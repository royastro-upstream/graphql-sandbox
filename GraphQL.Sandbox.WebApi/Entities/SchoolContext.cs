using Microsoft.EntityFrameworkCore;

namespace GraphQL.Sandbox.WebApi.Entities
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().HasData(
                    new Grade
                    {
                        GradeId = 1,
                        GradeName = "A",
                        Section = "SectionA"
                    },
                    new Grade
                    {
                        GradeId = 2,
                        GradeName = "B",
                        Section = "SectionB"
                    }
                );

            modelBuilder.Entity<Student>().HasData(
                    new Student
                    {
                        StudentID = 1,
                        StudentName = "John Doe",
                        DateOfBirth = new DateTime(1980, 1, 3),                                                                        
                        GradeId = 1                
                    },
                    new Student
                    {
                        StudentID = 2,
                        StudentName = "Bill Gates",
                        DateOfBirth = new DateTime(1975, 10, 3),
                        GradeId = 2
                    }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolDB;Integrated Security=True");            
        }
    }
}