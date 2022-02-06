using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem.Database
{
    public static class Startup
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            services.
                AddDbContext<OrderingSystemDbContext>(options => options.UseSqlServer(
                    "server =.; database = OrderingSystem; Trusted_Connection = True"));
            return services;
        }
    }
}
