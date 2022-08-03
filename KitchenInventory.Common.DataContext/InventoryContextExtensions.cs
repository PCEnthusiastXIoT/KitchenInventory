using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenInventory.Common.DataContext
{
    public static class InventoryContextExtensions
    {
        /// <summary>
        /// Adds Inventory Context to the specified IServiceCollection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="connectionString">Set to override the default</param>
        /// <returns>An IServiceCollection that can be used to add more services</returns>
        public static IServiceCollection AddInventoryContext(
            this IServiceCollection services, string connectionString = "Data Source=.;Initial Catalog=KitchenInventory;" +
            "Integrated Security=True")
        {
            services.AddDbContext<KitchenInventoryContext>(options =>
                options.UseSqlServer(connectionString));
            return services;
        }
    }
}
