using M2S10API.Models;
using Microsoft.EntityFrameworkCore;

namespace exemploCode1th.Context
{
    public class ExemploApiContext : DbContext
    {
        public ExemploApiContext(DbContextOptions<ExemploApiContext> opt) : base(opt)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Register> Registers { get; set; }
    }
}
