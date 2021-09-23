using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


namespace WebStore123
{
    public class Program
    {
        public static void Main(string[] args)
        {
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