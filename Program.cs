using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace KSIMonitor {
    public class Program {
        public static async Task Main(string[] args) {
            var host = CreateHostBuilder(args).Build();

            _ = Task.Run(async () => {
                var logger = host.Services.GetRequiredService<ILogger<Program>>();
                try {
                    using (var scope = host.Services.CreateScope())
                        await onStartup(scope.ServiceProvider);
                } catch (System.Exception ex) {
                    logger.LogError(ex, "Error running Application OnStartup");
                }
            }).ConfigureAwait(false);

            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());


        public const string AppName = "KSI Monitor";

        public const string RoleNameRoleAdmin = "RoleAdmin";
        public const string RoleNameUser = "User";

        private static async Task onStartup(System.IServiceProvider serviceProvider) {
            var dbContext = serviceProvider.GetRequiredService<Data.IApplicationDBContext>();

            await Microsoft.EntityFrameworkCore.RelationalDatabaseFacadeExtensions.MigrateAsync(dbContext.Database);

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] roleNames = new string[] { RoleNameRoleAdmin, RoleNameUser };
            var dbRoles = await Microsoft.EntityFrameworkCore.EntityFrameworkQueryableExtensions.ToListAsync(dbContext.Roles.Select(r => r.Name));
            foreach (string roleName in roleNames) {
                if (!dbRoles.Contains(roleName))
                    await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }
    }
}
