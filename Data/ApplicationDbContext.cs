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
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
        }
    }
}
