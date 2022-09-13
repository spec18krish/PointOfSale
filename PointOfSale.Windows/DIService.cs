using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PointOfSale.BL.Interface;
using PointOfSale.BL.Service;
using PointOfSale.Windows.Helpers;
using PointOfSale.Windows.Helpers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Windows
{
    public class DIService
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void RegisterServiceProvider()
        {
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
        }
        private static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                       .ConfigureServices(RegisterService);
        }

        private static void RegisterService(HostBuilderContext context, IServiceCollection services)
        {            
            
            services.AddTransient<IValidationHelpers, ValidationHelper>();
            services.AddTransient<IPointOfSaleService, PointOfSaleService>();
            services.AddSingleton<IProductInventoryService, ProductInventoryService>();
            services.AddTransient<POSForm>();
        }
    }
}
