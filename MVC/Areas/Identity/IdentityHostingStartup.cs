﻿using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(MVC.Areas.Identity.IdentityHostingStartup))]
namespace MVC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}