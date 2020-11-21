using System;
using ExpressJob.Areas.Identity.Data;
using ExpressJob.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(ExpressJob.Areas.Identity.IdentityHostingStartup))]
namespace ExpressJob.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ExpressJob.Data.ExpressJobContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("ExpressJobContextConnection")));

                services.AddDefaultIdentity<ExpressJobUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;

                    })
                    .AddEntityFrameworkStores<ExpressJob.Data.ExpressJobContext>();
            });
        }
    }
}