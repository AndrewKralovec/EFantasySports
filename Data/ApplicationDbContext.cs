using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EFantasySports.Models.Account;
using EFantasySports.Models.Game ; 
namespace EFantasySports.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
        }
    }
}
