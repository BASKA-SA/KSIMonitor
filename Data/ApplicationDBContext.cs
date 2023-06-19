using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KSIMonitor.Data {
    public interface IApplicationDBContext : IDBContext {
        // properties from Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDBContext
        //  Microsoft.AspNetCore.Identity.EntityFrameworkCore v6.0.16
        public DbSet<IdentityUser> Users { get; set; }
        public DbSet<IdentityUserClaim<string>> UserClaims { get; set; }
        public DbSet<IdentityUserLogin<string>> UserLogins { get; set; }
        public DbSet<IdentityUserToken<string>> UserTokens { get; set; }

        public DbSet<IdentityRole> Roles { get; set; }
        public DbSet<IdentityRoleClaim<string>> RoleClaims { get; set; }
        public DbSet<IdentityUserRole<string>> UserRoles { get; set; }
    }

    public class ApplicationDBContext : IdentityDbContext<IdentityUser>, IApplicationDBContext {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
    }
}
