using Microsoft.EntityFrameworkCore;

namespace bienesoft.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext>options) :base (options) { }

        public DbSet<LearnerModel> learners { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=Biensoft;User=root;Password=murcia21;Port=3306",
                    new MySqlServerVersion(new Version(8, 0, 39)));
            }
        }
    }
}
