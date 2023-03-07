using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using BryanCalderon.ArqLimpia.EN.Interfaces;

namespace BryanCalderon.ArqLimpia.DAL
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddDALDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BryanCalderonDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("conexion")));

            services.AddScoped<IUser,IUser>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
