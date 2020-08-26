using Autofac.Extensions.DependencyInjection;
using HappyDevops.AutofacAndAspnetCore3;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HappyDevops.AutofacandAspnetCore3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory()) //Necesario para inicializar Autofac
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
