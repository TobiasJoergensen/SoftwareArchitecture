using Application.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructureServices(this IHostApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("localDB");    

            builder.Services.AddDbContext<ApplicationDBContext>((sp, options) =>
            {
                options.UseSqlServer(connectionString);
            });

            builder.Services.AddScoped<IApplicationDBContext>(provider => provider.GetRequiredService<ApplicationDBContext>());
        }
    }
}
