using Microsoft.AspNetCore.Hosting;
[assembly: HostingStartup(typeof(StartupEnhancement.StartupEnhancementHostingStartup))]
namespace StartupEnhancement
{
    public class StartupEnhancementHostingStartup:IHostingStartup
    {
        public void Configure(IWebHostBuilder hostBuilder)
        {

        }
    }
}