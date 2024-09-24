using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

[assembly: HostingStartup(typeof(Host_Assembly.ServiceKeyInjection))]
namespace Host_Assembly
{
    public class ServiceKeyInjection : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(config =>
            {
            var dict = new Dictionary<string, string>
            {
                { "DevAccount_FromLibrary", "DEV_111_111" },
                { "ProdAccount_FromLibrary", "PROD_222_222" }
            };
            config.AddInMemoryCollection(dict);
            });
        }
    }
}