using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(KSIMonitor.Areas.Identity.IdentityHostingStartup))]
namespace KSIMonitor.Areas.Identity {
    public class IdentityHostingStartup : IHostingStartup {
        public void Configure(IWebHostBuilder builder) {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Data.ApplicationDBContext>(options =>
                    options.UseSqlServer(context.Configuration.GetConnectionString("KSIMonitorAppDB")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Data.ApplicationDBContext>();
            });
        }
    }
}
