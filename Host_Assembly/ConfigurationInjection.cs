using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
namespace Host_Assembly
{
    public class ConfigureInjection : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            Dictionary<string, string> dict;
            builder.ConfigureAppConfiguration(config =>
            {
                dict = new Dictionary<string, string>
                    {
                    {
                        "Configurationkey1","from this"+
                        "app configuration"},
                    };
                config.AddInMemoryCollection(dict);
            });
            dict = new Dictionary<string, string>
            {
                {"ConfigurationKey2",
                "From IHostingStartup: Lower priority " +
                "than the app's configuration."},
            };
            var builtConfig = new ConfigurationBuilder().
                AddInMemoryCollection(dict).
                Build();
            builder.UseConfiguration(builtConfig);
        }
    }
}