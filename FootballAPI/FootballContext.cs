using FootballAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballAPI
{
    public class FootballContext : DbContext
    {
        public DbSet<Player>? Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost,1433;Database=FootballDB;user=sa;pwd=Browns321";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Player>().HasData(
                new Player() { Id = 1, Name = "Jacoby Brisset", Team = "Browns", Position = "QB", TotalYards = 200, TotalTouchdowns = 20},
                new Player() { Id = 2, Name = "Nick Chubb", Team = "Browns", Position = "RB", TotalYards = 1000, TotalTouchdowns = 25},
                new Player() { Id = 3, Name = "Lamar Jackson", Team = "Ravens", Position = "QB", TotalYards = 1738, TotalTouchdowns = 32 },
                new Player() { Id = 4, Name = "Justin Jefferson", Team = "Vikings", Position = "WR", TotalYards = 756, TotalTouchdowns = 10 },
                new Player() { Id = 5, Name = "Mark Andrews", Team = "Ravens", Position = "TE", TotalYards = 450, TotalTouchdowns = 15 },
                new Player() { Id = 6, Name = "Randy Moss", Team = "Vikings", Position = "WR", TotalYards = 2219, TotalTouchdowns = 33  });

            base.OnModelCreating(model);
        }
    }
}
