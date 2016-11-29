using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EFantasySports.Models.Account;
using EFantasySports.Models.Game ; 
namespace EFantasySports.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {
        }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Roster> Rosters { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.Entity<League>().ToTable("League");
            builder.Entity<Player>().ToTable("Player");
            builder.Entity<Roster>().ToTable("Roster");
            builder.Entity<Team>().ToTable("Team");
        }
    }
}
