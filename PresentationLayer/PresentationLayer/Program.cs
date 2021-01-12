using BusinessLayer;
using DataAccessLayer;
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

            using(ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var home = serviceProvider.GetRequiredService<Home>();
                Application.Run(home);
             //   var formSignUp= serviceProvider.GetRequiredService<FormSignUp>();
              //  Application.Run(formSignUp);
            }

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserBusiness, UserBusiness>();
            services.AddScoped<Home>();
            services.AddScoped<FormSignUp>();

        }
    }
}
