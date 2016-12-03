using Microsoft.EntityFrameworkCore;
using EFantasySports.Models.Game ; 

namespace EFantasySports.Data
{
    public class GameDbContext : DbContext{
        public GameDbContext(DbContextOptions<GameDbContext> options): base(options) {
        }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<LeaguePlayer> LeaguePlayers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Manager> Managers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<League>().ToTable("Leagues");
            builder.Entity<Player>().ToTable("Players");
            builder.Entity<LeaguePlayer>().ToTable("LeaguePlayers");
            builder.Entity<Team>().ToTable("Teams");
            builder.Entity<Manager>().ToTable("Managers");
        }
    }
}
