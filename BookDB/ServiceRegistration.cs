using BookAbstraction.Interfaces;
using BookDB.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDB
{
    public static class ServiceRegistration
    {
        public static void AddBookDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IBookDbContext, BookDbContext>
                (options => options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
