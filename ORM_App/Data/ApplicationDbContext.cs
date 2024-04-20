using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ORM_App.Models;

namespace ORM_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ORM_App.Models.ExerciseType> ExerciseType { get; set; } = default!;
        public DbSet<ORM_App.Models.Exercise> Exercise { get; set; } = default!;
        public DbSet<ORM_App.Models.Session> Session { get; set; } = default!;
    }
}
