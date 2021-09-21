using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace _21._09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            var host_builder = CreateHostBuilder(args);
            var host = host_builder.Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(host => host
                    .UseStartup<Startup>()
                );
    }
}
