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
                // EmailSender already exists, but under KSIMonitor.Services.IEmailSender. Add it as implementing Identity.UI version
                services.AddTransient<Microsoft.AspNetCore.Identity.UI.Services.IEmailSender, Services.EmailSender>();

                // ApplicationDBContext already exists, but under KSIMonitor.Data.IApplicationDBContext. Add it as itself, which implements EFCore.DbContext, so AddIdentity works
                services.AddDbContext<Data.ApplicationDBContext>(options =>
                    options.UseSqlServer(context.Configuration.GetConnectionString("KSIMonitorAppDB")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Data.ApplicationDBContext>();
            });
        }
    }
}
