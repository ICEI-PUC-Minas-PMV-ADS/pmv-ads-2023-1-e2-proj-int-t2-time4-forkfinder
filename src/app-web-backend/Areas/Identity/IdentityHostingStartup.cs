using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(fork_finder.Areas.Identity.IdentityHostingStartup))]
namespace fork_finder.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}