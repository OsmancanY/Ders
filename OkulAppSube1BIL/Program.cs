using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OkulApp.BLL.Contexts;
using OkulApp.BLL.Repositories.OgretmenRepositories;
using System;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    internal static class Program
    {

        public static IServiceProvider ServiceProvider { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<AppDBContext>();
                    services.AddTransient<OgretmenWriteRepository>();
                    services.AddTransient<MainForm>();
                });
        }
    }
}
