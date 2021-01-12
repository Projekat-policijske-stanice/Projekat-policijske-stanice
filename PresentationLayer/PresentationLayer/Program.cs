using BusinessLayer;
using DataLayer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Interfaces.Business;
using Shared.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var main = serviceProvider.GetRequiredService<formMain>();
                Application.Run(main);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IPolicemanRepository, PolicemanRepository>();
            services.AddScoped<IPolicemanBusiness, PolicemanBusiness>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IVehicleBusiness, VehicleBusiness>();
            services.AddScoped<IOffenseRepository, OffenseRepository>();
            services.AddScoped<IOffenseBusiness, OffenseBusiness>();

            services.AddScoped<formMain>();
            services.AddScoped<formAdministration>();
            services.AddScoped<formOffenses>();
            services.AddScoped<formPolicemen>();
            services.AddScoped<formVehicles>();
        }
    }
}
