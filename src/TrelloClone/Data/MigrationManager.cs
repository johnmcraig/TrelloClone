using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrelloClone.Data
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
             using(var scope = host.Services.CreateScope())
             {
                 using(var appContext = scope.ServiceProvider.GetRequiredService<TrelloCloneDbContext>())
                 {
                    try
                    {
                        appContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex}");
                        throw;
                    }
                 }
             }

            return host;
        }
    }
}
