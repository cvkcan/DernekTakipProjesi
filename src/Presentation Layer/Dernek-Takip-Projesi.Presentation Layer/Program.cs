using Dernek_Takip_Projesi.Business_Layer.Features.Dgw_Business;
using Dernek_Takip_Projesi.Business_Layer.Features.Entities_Business;
using Dernek_Takip_Projesi.Data_Access_Layer.Entities;
using Dernek_Takip_Projesi.Presentation_Layer.Pages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace Dernek_Takip_Projesi.Presentation_Layer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            //Program çalıştırılırken servisin kullanılmasını sağladım.

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ServiceProvider.GetRequiredService<Homepage>());
        }
        //Dependency Injection (DI) için servis oluşturdum.
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((services) =>
                {
                    services.AddScoped<MemberController>();
                    services.AddScoped<EmailController>();
                    services.AddScoped<RevenueController>();
                    services.AddScoped<DebtorController>();
                    services.AddScoped<ExportDgw>();
                    services.AddScoped<Homepage>();
                    services.AddScoped<Email>();
                    //Servisleri Scoped ile uyguladım.
                });
        }
    }
}
