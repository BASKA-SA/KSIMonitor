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

                services.AddIdentity<IdentityUser, IdentityRole>(options => {
                    options.User.RequireUniqueEmail = true;
                    options.SignIn.RequireConfirmedAccount = true; //                           .AddDefaultUI is required for some files that are not scaffolded, see https://stackoverflow.com/a/65017563/2999220
                }).AddEntityFrameworkStores<Data.ApplicationDBContext>().AddDefaultTokenProviders().AddDefaultUI();
            });
        }
    }
}
