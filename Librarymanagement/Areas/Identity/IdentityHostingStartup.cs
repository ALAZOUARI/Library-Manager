using System;
using Librarymanagement.Areas.Identity.Data;
using Librarymanagement.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Librarymanagement.Areas.Identity.IdentityHostingStartup))]
namespace Librarymanagement.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserAuthDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserAuthDbContextConnection")));

                services.AddDefaultIdentity<LibrarytUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false; 

                    
                    })
                    .AddEntityFrameworkStores<UserAuthDbContext>();
            });
        }
    }
}