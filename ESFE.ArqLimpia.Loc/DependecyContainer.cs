using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using BryanCalderon.ArqLimpia.DAL;
using BryanCalderon.ArqLimpia.BL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace BryanCalderon.ArqLimpia.IoC
{
    public static class DependecyContainer
    {

        public static IServiceCollection AddBryanCalderonDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALDependecies(configuration);
            services.AddBLDependecies();
            return services;
        }
    }
}
